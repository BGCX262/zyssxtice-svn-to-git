using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Form_Pub
{
    public partial class Frm_系统通知 : Frm_pub
    {
        public Frm_系统通知()
        {
            InitializeComponent();
        }

        private void Frm_SysNotifying_Load(object sender, EventArgs e)
        {
            rtxtSysNotifying.Focus();
            rtxtSysNotifying.Height = this.Height - ice_Line1.Height - pn_title.Height - 30;
        }

        private void ice_DBButton1_Ice_DBButtonKeydowned(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.B)
            {
                MessageBox.Show("hello boy");
            }
        }

        private void btnRefresh_Ice_DBButtonClicked(object sender, EventArgs e)
        {

        }
    }
}