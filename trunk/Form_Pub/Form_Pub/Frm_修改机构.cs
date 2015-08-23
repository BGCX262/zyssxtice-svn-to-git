using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Form_Pub
{
    public partial class Frm_修改机构 : Frm_Pub2
    {
        public Frm_修改机构()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_AlterHospital_Load(object sender, EventArgs e)
        {
            txtOleHospital.Text = Gv_Data.Gv_Hospital;
            
        }

        private void Frm_AlterHospital_Shown(object sender, EventArgs e)
        {
            this.txtNewHospital.Focus();
        }
    }
}