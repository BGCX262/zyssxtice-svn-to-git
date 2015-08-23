using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Form_Pub
{
    public partial class Frm_锁定用户 : Frm_Pub2
    {
        public Frm_锁定用户()
        {
            InitializeComponent();
        }

        private void Frm_ClockUser_Load(object sender, EventArgs e)
        {
            Pub_Data.RemoveXButton(this.Handle.ToInt32());
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (btnShowPass.Text == "明码")
            {
                btnShowPass.Text = "暗码";
                txtUserPass.PasswordChar = Convert.ToChar(0);
            }
            else
            {
                btnShowPass.Text = "明码";
                txtUserPass.PasswordChar = '*';
            }
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}