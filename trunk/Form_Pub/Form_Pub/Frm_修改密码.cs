using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Form_Pub
{
    public partial class Frm_AlterPasword : Frm_Pub2
    {
        public Frm_AlterPasword()
        {
            InitializeComponent();
        }

        private void Frm_AlterHospital_Load(object sender, EventArgs e)
        {
            //txtOlePass.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_AlterPasword_Shown(object sender, EventArgs e)
        {
            txtOlePass.Focus();
        }
    }
}