﻿namespace Form_Pub
{
    partial class Frm_AlterPasword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AlterPasword));
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOlePass = new System.Windows.Forms.TextBox();
            this.txtNewPass1 = new System.Windows.Forms.TextBox();
            this.txtNewPass2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAlter
            // 
            this.btnAlter.BackColor = System.Drawing.Color.Transparent;
            this.btnAlter.Location = new System.Drawing.Point(23, 122);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(75, 23);
            this.btnAlter.TabIndex = 0;
            this.btnAlter.Text = "修改";
            this.btnAlter.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(146, 122);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "原密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "确认密码：";
            // 
            // txtOlePass
            // 
            this.txtOlePass.Location = new System.Drawing.Point(80, 12);
            this.txtOlePass.Name = "txtOlePass";
            this.txtOlePass.Size = new System.Drawing.Size(141, 21);
            this.txtOlePass.TabIndex = 5;
            // 
            // txtNewPass1
            // 
            this.txtNewPass1.Location = new System.Drawing.Point(80, 47);
            this.txtNewPass1.Name = "txtNewPass1";
            this.txtNewPass1.Size = new System.Drawing.Size(141, 21);
            this.txtNewPass1.TabIndex = 6;
            // 
            // txtNewPass2
            // 
            this.txtNewPass2.Location = new System.Drawing.Point(80, 87);
            this.txtNewPass2.Name = "txtNewPass2";
            this.txtNewPass2.Size = new System.Drawing.Size(141, 21);
            this.txtNewPass2.TabIndex = 7;
            // 
            // Frm_AlterPasword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 168);
            this.Controls.Add(this.txtNewPass2);
            this.Controls.Add(this.txtNewPass1);
            this.Controls.Add(this.txtOlePass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAlter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_AlterPasword";
            this.Text = "修改密码";
            this.Shown += new System.EventHandler(this.Frm_AlterPasword_Shown);
            this.Load += new System.EventHandler(this.Frm_AlterHospital_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOlePass;
        private System.Windows.Forms.TextBox txtNewPass1;
        private System.Windows.Forms.TextBox txtNewPass2;
    }
}