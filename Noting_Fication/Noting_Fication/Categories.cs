using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic.Logging;
using Noting_Fication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Noting_Fication
{
    public partial class Categories : Form
    {
        private List<String> categories;
        private String connectionString = "server =LAPTOP-GFP4TUFC\\HALAM_SE170579; database= NotingFication; uid=sa;pwd=12345; TrustServerCertificate=True";
        private NotingFicationContext dbContext;
        public TextBox? txtNew { get; set; }

        public Categories()
        {
            InitializeComponent();
            categories = new List<String>();
            dbContext = new NotingFicationContext();
        }
        private void Categories_Load(object sender, EventArgs e)
        {
            LoadCategories();
            btn_AddCat.Enabled = true;
            btn_DeleteCat.Enabled = true;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null && e.Node.Parent != null)
            {
                String selectCategory = e.Node.Text;
                DisplayNoteForCat(selectCategory);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Note_Categories.SelectedItems.Count > 0)
            {
                String selectNote = Note_Categories.SelectedItems[0].Text;
                MessageBox.Show($"You selected the note: {selectNote}", "Note Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        //====================================================================================//
        private AddCategories addForm;
        private void btn_AddCat_Click(object sender, EventArgs e)
        {
            Categories categoriesForm = new Categories();
            //AddCategories addForm = new AddCategories(categoriesForm);
            if (addForm == null || addForm.IsDisposed)
            {
                addForm = new AddCategories(categoriesForm);
                addForm.Owner = this;
                addForm.FormClosed += Categories_Load;
            }
            addForm.Show();
            btn_AddCat.Enabled = true;
            btn_DeleteCat.Enabled = true;
        }

        public void AddCategory(string category)
        {
            categories.Add(category);
            SaveCategories();

        }
        public void AddCategoryToListCate(string categoryName)
        {
            if (!categories.Contains(categoryName))
            {
                categories.Add(categoryName);
                TreeNode categoryNode = new TreeNode(categoryName);
                categoryNode.Tag = categoryName;
            }
            
        }

        //===================================================================================//

        private void btn_DeleteCat_Click(object sender, EventArgs e)
        {
            if (Note_Categories.SelectedItems.Count > 0)
            {
                string selectedCategory = Note_Categories.SelectedItems[0].Text;

                if (MessageBox.Show($"Are you sure you want to delete the category '{selectedCategory}'?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    categories.Remove(selectedCategory);
                    SaveCategories();
                    DisplayCategories();
                }
            }
            TreeNode selectedNode = listCate.SelectedNode;
            if (selectedNode != null)
            {
                string selectedCategory = selectedNode.Text;

                if (MessageBox.Show($"Are you sure you want to delete the category '{selectedCategory}'?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Delete the category from the TreeView
                    listCate.Nodes.Remove(selectedNode);

                    // Delete the category from the database
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string deleteCat = "DELETE FROM Category WHERE CategoryName = @CategoryName;";
                        using (SqlCommand deleteCmd = new SqlCommand(deleteCat, conn))
                        {
                            deleteCmd.Parameters.AddWithValue("@CategoryName", selectedCategory);
                            deleteCmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show($"Category '{selectedCategory}' has been deleted successfully.", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a category to delete.", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void afterSelectCategory(object sender, EventArgs e)
        {
            btn_DeleteCat.Enabled = (listCate.SelectedNode != null);
        }

        //===============================================================================//
        private void SaveCategories()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string deleteCat = "DELETE FROM Category;";
                    using (SqlCommand deleteCmd = new SqlCommand(deleteCat, conn))
                    {
                        deleteCmd.ExecuteNonQuery();
                    }

                    string insertCat = "INSERT INTO Category (CategoryId, CategoryName) VALUES (@CategoryId, @CategoryName);";
                    using (SqlCommand insertCmd = new SqlCommand(insertCat, conn))
                    {
                        foreach (string category in categories)
                        {
                            int categoryId = GenerateCategoryId();
                            insertCmd.Parameters.AddWithValue("CategoryId", categoryId);
                            insertCmd.Parameters.AddWithValue("@CategoryName", category);
                            insertCmd.ExecuteNonQuery();
                            insertCmd.Parameters.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SaveCategories has error: " + ex.Message);
            }
        }

        private int GenerateCategoryId()
        {
            int maxCategoryId = GetMaxCategoryId(); // Retrieve the maximum existing category ID from the database
            int newCategoryId = maxCategoryId + 1; // Increment it by 1 to generate a unique category ID
            return newCategoryId;
        }

        private int GetMaxCategoryId()
        {
            string sql = "SELECT MAX(CategoryId) FROM Category;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        int maxId = Convert.ToInt32(result);
                        return maxId;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
        //===============================================================================//
        private void LoadCategories()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "SELECT CategoryName FROM Category";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        SqlDataReader r = cmd.ExecuteReader();
                        List<string> catNames = new List<string>(); 
                        categories.Clear();
                        while (r.Read())
                        {
                            catNames.Add(r.GetString(0));
                        }
                        categories = catNames;
                        
                    }
                }
                DisplayCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LoadCategories has error: " + ex.Message);
            }
        }

        private void DisplayCategories()
        {
            foreach (String category in categories)
            {
                TreeNode catNode = listCate.Nodes.Add(category);

            }

        }
        private void DisplayNoteForCat(String category)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT Name FROM Note WHERE Category = @Category;";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Category", category);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            string note = reader.GetString(0);
                            ListViewItem item = new ListViewItem(note);
                            Note_Categories.Items.Add(item);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Display Note For Categories has error: " + ex.Message);
            }
        }
        //private void ClearCategoryField()
        //{
        //    txtNew.Text = string.Empty;
        //}

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //===================================================================================

    }
}
