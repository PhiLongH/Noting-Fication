using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using Noting_Fication.Models;
using Noting_Fication.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private NotingFication_2Context dbContext;
        public Userservice _userservice;
        public CateService _cateService;
        public NoteService _noteService;
        static int iduser;
        public TextBox? txtNew { get; set; }

        public Categories(int id)
        {
            iduser = id;
            InitializeComponent();
            dbContext = new NotingFication_2Context();
        }
        private void Categories_Load(object sender, EventArgs e)
        {
            LoadCategories();
            btn_AddCat.Enabled = true;
            btn_DeleteCat.Enabled = true;
        }
        private TreeNode selectedCategoryNode;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null && e.Node.Tag != null)
            {
                int categoryId = (int)e.Node.Tag;
                List<Note> notes = dbContext.Notes.Where(n => n.CategoryId == categoryId).ToList();

                SetupListViewColumns();
                DisplayNotes(notes);
            }
            if (e.Node.Checked)
            {
                selectedCategoryNode = e.Node;
            }
            else
            {
                selectedCategoryNode = null;
            }
        }
        private void DisplayNotes(List<Note> notes)
        {

            Note_Categories.Items.Clear();

            foreach (Note note in notes)
            {
                ListViewItem listItem = new ListViewItem(note.Name);

                listItem.SubItems.Add(note.Deadline.ToString());
                listItem.SubItems.Add(note.CreateDate.ToString());

                Note_Categories.Items.Add(listItem);
            }
        }
        private void SetupListViewColumns()
        {
            Note_Categories.Columns.Clear();

            Note_Categories.Columns.Add("NoteName");

            Note_Categories.Columns.Add("Deadline");

            Note_Categories.Columns.Add("CreateDate");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Note_Categories.SelectedItems.Count > 0)
            {
                String selectNote = Note_Categories.SelectedItems[0].Text;


            }
        }

        //====================================================================================//
        //private AddCategories addForm;
        private void btn_AddCat_Click(object sender, EventArgs e)
        {
            AddCategories addForm = new AddCategories(iduser);
            //Categories categoriesForm = new Categories(iduser);     
            addForm.Show();
            LoadCategories();
            btn_AddCat.Enabled = true;
            btn_DeleteCat.Enabled = true;
        }

        public void AddCategoryToListCate(string categoryName)
        {
            Category caat = new Category();
            caat.CategoryName = categoryName;
            var cat = _cateService.GetAll().FirstOrDefault();
            if (cat == null)
            {
                dbContext.Categories.Add(caat);
                TreeNode categoryNode = new TreeNode(categoryName);
                categoryNode.Tag = categoryName;
            }
            else
            {
                MessageBox.Show("Category is already existed!", "Delete task", MessageBoxButtons.OK);
            }

        }

        //===================================================================================//

        private void btn_DeleteCat_Click(object sender, EventArgs e)
        {
            if (selectedCategoryNode != null)
            {
                if (MessageBox.Show("Are you sure you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Delete the category from the database
                    string categoryName = selectedCategoryNode.Text;
                    // Use your ORM framework or database logic to delete the category
                    // For example, using Entity Framework:
                    using (var dbContext = new NotingFication_2Context())
                    {
                        Category categoryToDelete = dbContext.Categories.FirstOrDefault(c => c.CategoryName == categoryName);
                        if (categoryToDelete != null)
                        {
                            dbContext.Categories.Remove(categoryToDelete);
                            dbContext.SaveChanges();
                        }
                    }
                    selectedCategoryNode.Remove();
                    selectedCategoryNode = null;
                    MessageBox.Show("Category deleted successfully.", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a category to delete.", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void afterSelectCategory(object sender, EventArgs e)
        {
            btn_DeleteCat.Enabled = (listCate.SelectedNode != null);
        }

        //===============================================================================//
        private void LoadCategories()
        {
            List<Category> categories = dbContext.Categories.ToList();

            listCate.Nodes.Clear();

            foreach (Category category in categories)
            {
                TreeNode node = new TreeNode(category.CategoryName);
                node.Tag = category.CategoryId;
                listCate.Nodes.Add(node);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private string filepath;
        private void Note_Categories_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hitTest = Note_Categories.HitTest(e.Location);
            if (Note_Categories.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = Note_Categories.SelectedItems[0];
                string nodeName = selectedItem.SubItems[0].Text;

                using (var context = new NotingFication_2Context())
                {
                    var notd = context.Notes.Where(n=>n.Name == nodeName).FirstOrDefault();
                    filepath = notd.Content;
                }
                showedit();
            }
        }
        public void showedit()
        {
            EditForm form3 = new EditForm(iduser, filepath);
            form3.TopLevel = false;
            form3.TopMost = true;
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            Panel panel1 = (Panel)form1.Controls["panel2"];
            panel1.Controls.Clear();
            panel1.Controls.Add(form3);
            form3.Show();
        }
        //===================================================================================

    }
}
