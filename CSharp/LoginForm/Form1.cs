using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            Task.Delay(1250).Wait();
            Application.Exit();
        }

        private void chkBx_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBx_showpassword.Checked == true)
            {
                txtBx_paswrd.PasswordChar = '\0';
            }
            else
            {
                txtBx_paswrd.PasswordChar = '*';
            }
        }

        private void btn_sgnin_Click(object sender, EventArgs e)
        {
            if (txtBx_usr.Text == "Admin" && txtBx_paswrd.Text == "123")
            {
                MessageBox.Show("Right...");
                txtBx_paswrd.Text = "";
                txtBx_usr.Text = "";
            }
            if (txtBx_usr.Text != "Admin" && txtBx_paswrd.Text != "123")
            {
                MessageBox.Show("Username and Password wrong...", "Login ERROR");
                txtBx_paswrd.Text = "";
                txtBx_usr.Text = "";
            }
        }
    }
}
