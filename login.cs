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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (username.Text != null && password.Text != null)
            {
                HalamanLogin.Enabled = true;
            }
            else
            {
                HalamanLogin.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) //checkbox show password
        {
            if (PasswordcheckBox.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void bMasuk_Click(object sender, EventArgs e) //ketika button login di pencet
        {

            if (termCheckbox.Checked) //ini kamu ga perlu tulis
            {
                string usernametext = username.Text; //mulai sini kamu tulis
                string passwordtext = password.Text;

                if (usernametext == "admin" && passwordtext == "admin") //username n pass
                {
                    HalamanUtama f= new HalamanUtama();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Gagal");
                } //sampe sini
            }
            else //ini juga ga perlu
            {
                MessageBox.Show("Mohon untuk menyetujui syarat dan ketentuan aplikasi.");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //checkbox term and conditions
        {
        }
    }
}
