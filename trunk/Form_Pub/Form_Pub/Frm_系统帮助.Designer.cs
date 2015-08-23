namespace Form_Pub
{
    partial class Frm_系统帮助
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_系统帮助));
            this.rtxtHelp = new System.Windows.Forms.RichTextBox();
            this.pn_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.Location = new System.Drawing.Point(332, 9);
            this.lb_Title.Size = new System.Drawing.Size(163, 35);
            this.lb_Title.Text = "系统帮助";
            // 
            // imageList_pub
            // 
            this.imageList_pub.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_pub.ImageStream")));
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
            // rtxtHelp
            // 
            this.rtxtHelp.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtxtHelp.ForeColor = System.Drawing.Color.Red;
            this.rtxtHelp.Location = new System.Drawing.Point(12, 75);
            this.rtxtHelp.Name = "rtxtHelp";
            this.rtxtHelp.ReadOnly = true;
            this.rtxtHelp.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtHelp.Size = new System.Drawing.Size(768, 479);
            this.rtxtHelp.TabIndex = 3;
            this.rtxtHelp.Text = "快捷键：\n\nCtrl + Shift + O ：　打开脚本监视\n\nCtrl + Shift + I ：截图";
            // 
            // Frm_系统帮助
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.rtxtHelp);
            this.Name = "Frm_系统帮助";
            this.Text = "系统帮助";
            this.Load += new System.EventHandler(this.Frm_系统帮助_Load);
            this.Controls.SetChildIndex(this.rtxtHelp, 0);
            this.Controls.SetChildIndex(this.pn_title, 0);
            this.Controls.SetChildIndex(this.ice_Line1, 0);
            this.pn_title.ResumeLayout(false);
            this.pn_title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtHelp;
    }
}