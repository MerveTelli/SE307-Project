using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Enter(object sender, EventArgs e)
        {

        }
        BookVT vtclass = new BookVT();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vtclass.List();
			dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book bkclass = new Book();
            bkclass.NAME = textBox1.Text;
            bkclass.AUTHOR = textBox2.Text;
            bkclass.LINK = textBox3.Text;
            vtclass.KitapEkle(bkclass);
            MessageBox.Show("Your Book is Added", "Saved",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[selected].Cells[3].Value.ToString();

            webBrowser1.Navigate(link);
        }

        

        private void button3_Click(object sender, EventArgs e)
        {

            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            //FullScreen frm = new FullScreen();
            //this.Hide();
            //frm.ShowDialog();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Book dlclass = new Book();
            dlclass.NAME = textBox1.Text;
            dlclass.AUTHOR = textBox2.Text;
            dlclass.LINK = textBox3.Text;
            vtclass.KitapSil(dlclass);
            MessageBox.Show("Your Book is Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       /* private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
        }

         private void Form1_KeyDown(object sender, KeyEventArgs e)
         {
             if (e.KeyCode == Keys.Escape)
             {
                 int w = Screen.PrimaryScreen.Bounds.Width;
                 int h = Screen.PrimaryScreen.Bounds.Height;
                 this.Location = new Point(0, 0);
                 this.Size = new Size(898, 513);

             }
         } */
    }
}
