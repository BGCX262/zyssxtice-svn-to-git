namespace Form_Pub
{
    partial class Frm_pub
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_pub));
            this.pn_title = new System.Windows.Forms.Panel();
            this.pn_buttons = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.imageList_pub = new System.Windows.Forms.ImageList(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.lb_Title = new System.Windows.Forms.Label();
            this.ice_Line1 = new VerticalLine.Ice_Line();
            this.pn_title.SuspendLayout();
            this.pn_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_title
            // 
            this.pn_title.BackColor = System.Drawing.Color.Transparent;
            this.pn_title.Controls.Add(this.pn_buttons);
            this.pn_title.Controls.Add(this.lb_Title);
            this.pn_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_title.Location = new System.Drawing.Point(0, 0);
            this.pn_title.Name = "pn_title";
            this.pn_title.Size = new System.Drawing.Size(792, 59);
            this.pn_title.TabIndex = 1;
            this.pn_title.SizeChanged += new System.EventHandler(this.pn_title_SizeChanged);
            // 
            // pn_buttons
            // 
            this.pn_buttons.BackColor = System.Drawing.Color.Transparent;
            this.pn_buttons.Controls.Add(this.btnHelp);
            this.pn_buttons.Controls.Add(this.btnClose);
            this.pn_buttons.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_buttons.Location = new System.Drawing.Point(596, 0);
            this.pn_buttons.Name = "pn_buttons";
            this.pn_buttons.Size = new System.Drawing.Size(196, 59);
            this.pn_buttons.TabIndex = 3;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.ImageIndex = 4;
            this.btnHelp.ImageList = this.imageList_pub;
            this.btnHelp.Location = new System.Drawing.Point(16, 23);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(62, 27);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "帮助";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // imageList_pub
            // 
            this.imageList_pub.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_pub.ImageStream")));
            this.imageList_pub.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_pub.Images.SetKeyName(0, "x.png");
            this.imageList_pub.Images.SetKeyName(1, "rss.png");
            this.imageList_pub.Images.SetKeyName(2, "search.png");
            this.imageList_pub.Images.SetKeyName(3, "settings.png");
            this.imageList_pub.Images.SetKeyName(4, "technorati.png");
            this.imageList_pub.Images.SetKeyName(5, "user-female.png");
            this.imageList_pub.Images.SetKeyName(6, "user-male.png");
            this.imageList_pub.Images.SetKeyName(7, "users.png");
            this.imageList_pub.Images.SetKeyName(8, "add.png");
            this.imageList_pub.Images.SetKeyName(9, "comment.png");
            this.imageList_pub.Images.SetKeyName(10, "diskette.png");
            this.imageList_pub.Images.SetKeyName(11, "document.png");
            this.imageList_pub.Images.SetKeyName(12, "documents.png");
            this.imageList_pub.Images.SetKeyName(13, "home.png");
            this.imageList_pub.Images.SetKeyName(14, "left.png");
            this.imageList_pub.Images.SetKeyName(15, "pencil.png");
            this.imageList_pub.Images.SetKeyName(16, "pie-chart.png");
            this.imageList_pub.Images.SetKeyName(17, "recycle.png");
            this.imageList_pub.Images.SetKeyName(18, "right.png");
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.ImageIndex = 0;
            this.btnClose.ImageList = this.imageList_pub;
            this.btnClose.Location = new System.Drawing.Point(122, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 27);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            this.btnClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClose_KeyDown);
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("楷体_GB2312", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Title.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_Title.Location = new System.Drawing.Point(310, 9);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(129, 35);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "XXXXXX";
            // 
            // ice_Line1
            // 
            this.ice_Line1.BackColor = System.Drawing.Color.Transparent;
            this.ice_Line1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ice_Line1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ice_Line1.LineType = VerticalLine.Ice_Line.HLineType.Single;
            this.ice_Line1.Location = new System.Drawing.Point(0, 59);
            this.ice_Line1.Name = "ice_Line1";
            this.ice_Line1.Size = new System.Drawing.Size(792, 10);
            this.ice_Line1.TabIndex = 2;
            // 
            // Frm_pub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.ice_Line1);
            this.Controls.Add(this.pn_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_pub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_pub";
            this.Load += new System.EventHandler(this.Frm_pub_Load);
            this.pn_title.ResumeLayout(false);
            this.pn_title.PerformLayout();
            this.pn_buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_buttons;
        public System.Windows.Forms.Panel pn_title;
        public System.Windows.Forms.Label lb_Title;
        public System.Windows.Forms.Button btnHelp;
        public VerticalLine.Ice_Line ice_Line1;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.ImageList imageList_pub;
    }
}