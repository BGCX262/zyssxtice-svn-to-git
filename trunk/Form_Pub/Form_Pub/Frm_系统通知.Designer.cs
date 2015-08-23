namespace Form_Pub
{
    partial class Frm_系统通知
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_系统通知));
            this.rtxtSysNotifying = new System.Windows.Forms.RichTextBox();
            this.btnRefresh = new Ice_DBButton.Ice_DBButton();
            this.pn_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.Location = new System.Drawing.Point(332, 9);
            this.lb_Title.Size = new System.Drawing.Size(163, 35);
            this.lb_Title.Text = "系统通知";
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
            // rtxtSysNotifying
            // 
            this.rtxtSysNotifying.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxtSysNotifying.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtxtSysNotifying.ForeColor = System.Drawing.Color.Red;
            this.rtxtSysNotifying.Location = new System.Drawing.Point(0, 114);
            this.rtxtSysNotifying.Name = "rtxtSysNotifying";
            this.rtxtSysNotifying.ReadOnly = true;
            this.rtxtSysNotifying.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtxtSysNotifying.Size = new System.Drawing.Size(792, 452);
            this.rtxtSysNotifying.TabIndex = 3;
            this.rtxtSysNotifying.Text = "系统通知：\n\n\n　　　　召开全体大会！";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.ButtonColor = System.Drawing.Color.Transparent;
            this.btnRefresh.ButtonImageIndex = 9;
            this.btnRefresh.ButtonImageList = this.imageList_pub;
            this.btnRefresh.ButtonText = "刷新";
            this.btnRefresh.ConnectionStr = "";
            this.btnRefresh.Location = new System.Drawing.Point(12, 75);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 33);
            this.btnRefresh.SQL_DBModify = "";
            this.btnRefresh.SQL_DBSearch = "";
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Ice_DBButtonClicked += new Ice_DBButton.Ice_DBButton.DBButtonClickHandle(this.btnRefresh_Ice_DBButtonClicked);
            // 
            // Frm_SysNotifying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.rtxtSysNotifying);
            this.Controls.Add(this.btnRefresh);
            this.Name = "Frm_SysNotifying";
            this.Text = "系统通知";
            this.Load += new System.EventHandler(this.Frm_SysNotifying_Load);
            this.Controls.SetChildIndex(this.btnRefresh, 0);
            this.Controls.SetChildIndex(this.rtxtSysNotifying, 0);
            this.Controls.SetChildIndex(this.pn_title, 0);
            this.Controls.SetChildIndex(this.ice_Line1, 0);
            this.pn_title.ResumeLayout(false);
            this.pn_title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtSysNotifying;
        private Ice_DBButton.Ice_DBButton btnRefresh;
    }
}