
namespace EXEPABD
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HalamanLogin = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.termCheckbox = new System.Windows.Forms.CheckBox();
            this.PasswordcheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // HalamanLogin
            // 
            this.HalamanLogin.BackColor = System.Drawing.Color.Lime;
            this.HalamanLogin.Enabled = false;
            this.HalamanLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.HalamanLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HalamanLogin.ForeColor = System.Drawing.Color.White;
            this.HalamanLogin.Location = new System.Drawing.Point(414, 322);
            this.HalamanLogin.Name = "HalamanLogin";
            this.HalamanLogin.Size = new System.Drawing.Size(80, 32);
            this.HalamanLogin.TabIndex = 0;
            this.HalamanLogin.Text = "Masuk";
            this.HalamanLogin.UseVisualStyleBackColor = false;
            this.HalamanLogin.Click += new System.EventHandler(this.bMasuk_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(324, 191);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(170, 20);
            this.username.TabIndex = 1;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(324, 236);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(170, 20);
            this.password.TabIndex = 2;
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.Red;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.Location = new System.Drawing.Point(324, 322);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(80, 32);
            this.bExit.TabIndex = 5;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(212, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(429, 43);
            this.label3.TabIndex = 6;
            this.label3.Text = "DATA MAHASISWA TI";
            // 
            // termCheckbox
            // 
            this.termCheckbox.AutoSize = true;
            this.termCheckbox.Location = new System.Drawing.Point(324, 299);
            this.termCheckbox.Name = "termCheckbox";
            this.termCheckbox.Size = new System.Drawing.Size(123, 17);
            this.termCheckbox.TabIndex = 7;
            this.termCheckbox.Text = "Term and Conditions";
            this.termCheckbox.UseVisualStyleBackColor = true;
            this.termCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // PasswordcheckBox
            // 
            this.PasswordcheckBox.AutoSize = true;
            this.PasswordcheckBox.Location = new System.Drawing.Point(324, 276);
            this.PasswordcheckBox.Name = "PasswordcheckBox";
            this.PasswordcheckBox.Size = new System.Drawing.Size(102, 17);
            this.PasswordcheckBox.TabIndex = 8;
            this.PasswordcheckBox.Text = "Show Password";
            this.PasswordcheckBox.UseVisualStyleBackColor = true;
            this.PasswordcheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PasswordcheckBox);
            this.Controls.Add(this.termCheckbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.HalamanLogin);
            this.Name = "login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HalamanLogin;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox termCheckbox;
        private System.Windows.Forms.CheckBox PasswordcheckBox;
    }
}

