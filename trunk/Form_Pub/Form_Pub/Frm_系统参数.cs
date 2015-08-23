using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Form_Pub
{
    public partial class Frm_系统参数 : Frm_pub
    {
        public Frm_系统参数()
        {
            InitializeComponent();
        }      

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // Getting the graphics object
            Graphics g = pevent.Graphics;

            // Creating the rectangle for the gradient
            Rectangle rBackground = new Rectangle(0, 0, this.Width, this.Height);

            // Creating the lineargradient
            System.Drawing.Drawing2D.LinearGradientBrush bBackground
                = new System.Drawing.Drawing2D.LinearGradientBrush(rBackground, Gv_Data._Color1, Gv_Data._Color2, Gv_Data._ColorAngle);

            // Draw the gradient onto the form
            g.FillRectangle(bBackground, rBackground);

            // Disposing of the resources held by the brush
            bBackground.Dispose();
        }

        private void Frm_SysParams_Load(object sender, EventArgs e)
        {
            foreach (KnownColor c in Enum.GetValues(typeof(KnownColor)))
            {
                cbYZColor.Items.Add(c.ToString());
            }

        }

        private void cbYZColor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            label4.BackColor = Color.FromName(cbYZColor.Text);
        }
    }
}