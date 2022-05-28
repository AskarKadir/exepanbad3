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
    public partial class CardView : Form
    {
        public CardView()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DataGrid dg = new DataGrid();
            dg.Show();
            this.Hide();
        }
    }
}
