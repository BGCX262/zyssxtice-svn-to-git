namespace Form_Pub
{
    partial class Frm_系统参数
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_系统参数));
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSkins = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbYZColor = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.txtMaxYZ = new System.Windows.Forms.TextBox();
            this.pn_title.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.Location = new System.Drawing.Point(332, 9);
            this.lb_Title.Size = new System.Drawing.Size(163, 35);
            this.lb_Title.Text = "系统参数";
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
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageKey = "diskette.png";
            this.btnSave.ImageList = this.imageList_pub;
            this.btnSave.Location = new System.Drawing.Point(14, 75);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 29);
            this.btnSave.TabIndex = 5;
            this.btnSave.Tag = "Ｆ３";
            this.btnSave.Text = "保存";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ImageKey = "(无)";
            this.label1.Location = new System.Drawing.Point(48, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "系统皮肤：";
            // 
            // cbSkins
            // 
            this.cbSkins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSkins.FormattingEnabled = true;
            this.cbSkins.Items.AddRange(new object[] {
            "春意黯然",
            "夏日海洋",
            "秋风飒爽",
            "冬天严寒"});
            this.cbSkins.Location = new System.Drawing.Point(119, 147);
            this.cbSkins.Name = "cbSkins";
            this.cbSkins.Size = new System.Drawing.Size(142, 20);
            this.cbSkins.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(24, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "最大医嘱数目：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "是否显示快速栏：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(48, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "医嘱颜色：";
            // 
            // cbYZColor
            // 
            this.cbYZColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYZColor.FormattingEnabled = true;
            this.cbYZColor.Location = new System.Drawing.Point(119, 345);
            this.cbYZColor.Name = "cbYZColor";
            this.cbYZColor.Size = new System.Drawing.Size(142, 20);
            this.cbYZColor.TabIndex = 14;
            this.cbYZColor.SelectionChangeCommitted += new System.EventHandler(this.cbYZColor_SelectionChangeCommitted);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.rbNo);
            this.panel1.Controls.Add(this.rbYes);
            this.panel1.Location = new System.Drawing.Point(119, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 33);
            this.panel1.TabIndex = 17;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.BackColor = System.Drawing.Color.Transparent;
            this.rbNo.Location = new System.Drawing.Point(96, 10);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(35, 16);
            this.rbNo.TabIndex = 18;
            this.rbNo.Text = "否";
            this.rbNo.UseVisualStyleBackColor = false;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.BackColor = System.Drawing.Color.Transparent;
            this.rbYes.Checked = true;
            this.rbYes.Location = new System.Drawing.Point(7, 10);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(35, 16);
            this.rbYes.TabIndex = 17;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "是";
            this.rbYes.UseVisualStyleBackColor = false;
            // 
            // txtMaxYZ
            // 
            this.txtMaxYZ.Location = new System.Drawing.Point(119, 209);
            this.txtMaxYZ.Name = "txtMaxYZ";
            this.txtMaxYZ.Size = new System.Drawing.Size(142, 21);
            this.txtMaxYZ.TabIndex = 18;
            // 
            // Frm_SysParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.txtMaxYZ);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbYZColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSkins);
            this.Controls.Add(this.btnSave);
            this.Name = "Frm_SysParams";
            this.Text = "系统参数";
            this.Load += new System.EventHandler(this.Frm_SysParams_Load);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.pn_title, 0);
            this.Controls.SetChildIndex(this.ice_Line1, 0);
            this.Controls.SetChildIndex(this.cbSkins, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cbYZColor, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.txtMaxYZ, 0);
            this.pn_title.ResumeLayout(false);
            this.pn_title.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSkins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbYZColor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.TextBox txtMaxYZ;
    }
}