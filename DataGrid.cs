using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXEPABD
{
    public partial class DataGrid : Form
    {
        public DataGrid()
        {
            InitializeComponent();
        }


        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CardView cv = new CardView(); //halaman
            cv.NIM.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cv.NAMA.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cv.ALAMAT.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cv.JENIS.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cv.NOTEL.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();


            cv.Show(); 
            //this.Show();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);
            //Costumizing onload table background
            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = System.Drawing.Color.Purple;
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = System.Drawing.Color.Green;
            dataGridView1.Columns[4].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
            //Textalignment for specific cell / header
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //text style for header
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);

        }

        //onHovering Cell

        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Pink;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;
                //dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Pink;
                //dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
            }
            else if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Orange;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;
            }
            else if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Green;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;
            }
            else if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.DodgerBlue;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;
            }
            else if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.SaddleBrown;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;
            }
        }

        //onLeaving hover cell
        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Purple;
                //dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                //dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
            }
            else if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Blue;
            }
            else if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.DarkCyan;
            }
            else if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Green;
            }
            else if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Red;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HalamanUtama hu = new HalamanUtama();
            hu.Show();
            this.Hide();
        }
    }
}
