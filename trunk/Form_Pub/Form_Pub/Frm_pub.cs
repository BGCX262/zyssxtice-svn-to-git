﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Form_Pub
{
    public partial class Frm_pub : Form
    {
        public Frm_pub()
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

        private void Frm_pub_Load(object sender, EventArgs e)
        {
            lb_Title.Left = Convert.ToInt32(pn_title.Width * 0.5 - lb_Title.Width * 0.5);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pn_title_SizeChanged(object sender, EventArgs e)
        {
            lb_Title.Left = Convert.ToInt32(pn_title.Width * 0.5 - lb_Title.Width * 0.5);
        }

        private void btnClose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && e.Alt)
            {
                this.Close();
            }
        }
    }
}