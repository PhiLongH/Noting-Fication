using Noting_Fication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noting_Fication
{
    public partial class AddCategories : Form
    {
        private Categories categoriesForm;
        public string EnterCat { get { return txtNew.Text.Trim(); } }
        public AddCategories(Categories categoriesForm)
        {
            InitializeComponent();
            this.categoriesForm = categoriesForm;
            Wire();
        }
        private void Wire()
        {
            categoriesForm.txtNew = txtNew;
            btnADD.Click += btnAdd_Click_1;
        }
        private void btnAdd_Click_1(object? sender, EventArgs e)
        {
            string newCategory = txtNew.Text.Trim();

            if (!string.IsNullOrEmpty(newCategory))
            {
                categoriesForm.AddCategory(newCategory);
                categoriesForm.AddCategoryToListCate(newCategory);

                // Save the category to the database (assuming you have a method for saving categories)

                MessageBox.Show("New category saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close(); // Close the AddCategories form
            }
            else
            {
                MessageBox.Show("Please enter a valid category name.", "Invalid Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //String new_Category = txtNew.Text;
            //categoriesForm.AddCategory(new_Category);
            ////MessageBox.Show($"New category: {new_Category}");
            ////categoriesForm.AddCategoryToListCate(new_Category);
        }
    }

}

