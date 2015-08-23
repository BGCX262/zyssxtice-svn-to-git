using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Form_Pub
{
    public partial class Frm_关于 : Form
    {
        public Frm_关于()
        {
            InitializeComponent();
        }

        private void Frm_About_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}