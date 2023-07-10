using Noting_Fication.Models;
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
    public partial class Bins : Form
    {
        static int iduser;
        public Bins(int id)
        {
            iduser = id;
            InitializeComponent();
        }
        public   void LoadData()
        {
            using (var context = new NotingFicationContext())
            {
                List<Note> list = context.Notes.Where(x => x.UserId == iduser && x.Status == false).ToList();
                dataGridView1.Rows.Clear();
                foreach (Note item in list)
                {
                    var cate = context.Categories.FirstOrDefault(x => x.CategoryId == item.CategoryId);
                    dataGridView1.Rows.Add(item.NoteId, item.Name, item.Content, item.Deadline == null ? "" : item.Deadline.Value.ToString("dd-MM-yyyy"), cate.CategoryName, "Restore");
                }
            }
        }
        private void Bins_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Column6"].Index && e.RowIndex >= 0)
            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString());
                string title = dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
                DialogResult r = MessageBox.Show($"Ban muon khoi phuc : \nID: {id} \nTitle: {title}", "Thong bao", MessageBoxButtons.YesNo);
                if(r == DialogResult.Yes)
                {
                    using(var context = new NotingFicationContext())
                    {
                        Note n = context.Notes.FirstOrDefault(x => x.NoteId == id);
                        n.Status = true;
                        context.Notes.Update(n);
                        context.SaveChanges();
                    }
                    LoadData();
                }
            }
        }
    }
}
