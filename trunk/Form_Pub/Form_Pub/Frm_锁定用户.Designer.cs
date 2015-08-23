namespace Form_Pub
{
    partial class Frm_锁定用户
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_锁定用户));
            this.lb_tips = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.btnShowPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_tips
            // 
            this.lb_tips.AutoSize = true;
            this.lb_tips.BackColor = System.Drawing.Color.Transparent;
            this.lb_tips.ForeColor = System.Drawing.Color.Red;
            this.lb_tips.Location = new System.Drawing.Point(8, 26);
            this.lb_tips.Name = "lb_tips";
            this.lb_tips.Size = new System.Drawing.Size(221, 12);
            this.lb_tips.TabIndex = 0;
            this.lb_tips.Text = "当前用户已锁定，请输入密码解除锁定。";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户密码：";
            // 
            // txtUserPass
            // 
            this.txtUserPass.Location = new System.Drawing.Point(72, 77);
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.PasswordChar = '*';
            this.txtUserPass.Size = new System.Drawing.Size(157, 21);
            this.txtUserPass.TabIndex = 2;
            // 
            // btnUnlock
            // 
            this.btnUnlock.BackColor = System.Drawing.Color.Transparent;
            this.btnUnlock.Location = new System.Drawing.Point(154, 122);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(75, 23);
            this.btnUnlock.TabIndex = 3;
            this.btnUnlock.Text = "解锁";
            this.btnUnlock.UseVisualStyleBackColor = false;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // btnShowPass
            // 
            this.btnShowPass.BackColor = System.Drawing.Color.Transparent;
            this.btnShowPass.Location = new System.Drawing.Point(14, 122);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(75, 23);
            this.btnShowPass.TabIndex = 4;
            this.btnShowPass.Text = "明码";
            this.btnShowPass.UseVisualStyleBackColor = false;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // Frm_ClockUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(242, 167);
            this.Controls.Add(this.btnShowPass);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.txtUserPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_tips);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ClockUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户锁定";
            this.Load += new System.EventHandler(this.Frm_ClockUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_tips;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserPass;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.Button btnShowPass;
    }
}