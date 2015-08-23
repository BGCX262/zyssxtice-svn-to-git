using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Form_Pub
{
    public partial class Frm_主窗体 : Form
    {
        public Frm_主窗体()
        {
            InitializeComponent();
        }


        Frm_系统通知 ob_Frm_SysNotifying;
        Frm_问题反馈 ob_Frm_ReturnProblems;
        Frm_系统参数 ob_Frm_SysParams;
        Frm_手术申请 ob_Frm_手术申请;
        Frm_字典维护 ob_Frm_字典维护;
        Frm_医嘱模板 ob_Frm_医嘱模板;
        Frm_费用补录 ob_Frm_费用补录;
        Frm_费用冲减 ob_Frm_费用冲减;
        Frm_药品申请 ob_Frm_药品申请;
        Frm_汇总领药 ob_Frm_汇总领药;
        Frm_材料补录 ob_Frm_材料补录;
        Frm_手术排班 ob_Frm_手术排班;
        Frm_护士排班 ob_Frm_护士排班;
        Frm_报告编辑 ob_Frm_报告编辑;
        Frm_申请单作废 ob_Frm_申请单作废;
        Frm_手术单查询 ob_Frm_手术单查询;
        Frm_手术费用及人次统计 ob_Frm_手术费用及人次统计;
        Frm_手术费用统计 ob_Frm_手术费用统计;
        Frm_手术工作量统计 ob_Frm_手术工作量统计;
        Frm_手术例数统计＿按科室 ob_Frm_手术例数统计＿按科室;
        Frm_手术例数统计＿按医生 ob_Frm_手术例数统计＿按医生;
        Frm_手术明细费用查询 ob_Frm_手术明细费用查询;
        Frm_手术项目费用及人次统计 ob_Frm_手术项目费用及人次统计;
        Frm_汇总领药查询 ob_Frm_汇总领药查询;
        Frm_护士排班表查询 ob_Frm_护士排班表查询;
        Frm_病人手术费用查询 ob_Frm_病人手术费用查询;

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            btnSSGL_Click(sender, e);
            pnlMain.Visible = Gv_Data.Gv_IsShowFastBar;
            tsslHospital.Text = Gv_Data.Gv_Hospital;
            tsslUser.Text = Gv_Data.Gv_UserName;
            timer_pub.Start();
            //注册热键Ctrl+Shift+A，Id号为100。HotKey.KeyModifiers.Shift也可以直接使用数字4来表示。  
            Pub_Data.HotKey.RegisterHotKey(Handle, 100, Pub_Data.HotKey.KeyModifiers.Ctrl | Pub_Data.HotKey.KeyModifiers.Shift, Keys.I);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;//生成该消息的热键ID
            //按快捷键   
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        case 100:    //按下的是Ctrl+Shift+S  
                            System.Diagnostics.Process.Start(Application.StartupPath + "\\SNAPSHOT.EXE");
                            break;
                        //case 101:    //按下的是Ctrl+B  
                        //    //此处填写快捷键响应代码  
                        //    this.Text = "按下的是Ctrl+B";
                        //    break;
                        //case 102:    //按下的是Alt+D  
                        //    //此处填写快捷键响应代码  
                        //    this.Text = "按下的是Ctrl+Alt+D";
                        //    break;
                        //case 103:
                        //    this.Text = "F5";
                        //    break;
                    }
                    break;
            }
            base.WndProc(ref m);
        } 

        private bool HaveClosed(Form parent, string childName)
        {
            //查看窗口是否已经关闭
            bool bReturn = true;
            for (int i = 0; i < parent.MdiChildren.Length; i++)
            {
                if (parent.MdiChildren[i].Name == childName)
                {
                    parent.MdiChildren[i].BringToFront();
                    bReturn = false;
                    break;
                }
            }
            return bReturn;
        }

        private void toolStripMenuItem关于_Click(object sender, EventArgs e)
        {
            Frm_关于 ob_Frm_About = new Frm_关于();
            ob_Frm_About.Show();
        }

        private void toolStripMenuItem锁定用户_Click(object sender, EventArgs e)
        {
            Frm_锁定用户 ob_Frm_ClockUser = new Frm_锁定用户();
            ob_Frm_ClockUser.ShowDialog();
        }

        private void toolStripMenuItem系统通知_Click(object sender, EventArgs e)
        {
            if (HaveClosed(this, "Frm_SysNotifying"))
            {

                ob_Frm_SysNotifying = new Frm_系统通知();
                ob_Frm_SysNotifying.Name = "Frm_SysNotifying";
                ob_Frm_SysNotifying.MdiParent = this;
                SetFill(ob_Frm_SysNotifying);
                ob_Frm_SysNotifying.Show();
            }
            else
            {
               // SetFill(ob_Frm_SysNotify);
                ob_Frm_SysNotifying.Show();
            }     
        }

        public void SetFill(Form ob_form)
        {
            if (ob_form != null)
            {
                ob_form.Show();
                ob_form.Dock = DockStyle.Fill;
                int currwidth = ob_form.Width;
                int currheight = ob_form.Height;
                int currtop = ob_form.Top;
                int currleft = ob_form.Left;
                ob_form.Hide();
                ob_form.Dock = DockStyle.None;
                ob_form.Width = currwidth;
                ob_form.Height = currheight;
                ob_form.Left = currleft;
                ob_form.Top = currtop;
            }
            
        }

        private void toolStripMenuItem问题反馈_Click(object sender, EventArgs e)
        {
            if (HaveClosed(this, "Frm_ReturnProblems"))
            {

                ob_Frm_ReturnProblems = new Frm_问题反馈();
                ob_Frm_ReturnProblems.Name = "Frm_ReturnProblems";
                ob_Frm_ReturnProblems.MdiParent = this;
                SetFill(ob_Frm_ReturnProblems);
                ob_Frm_ReturnProblems.Show();
            }
            else
            {
                //SetFill(ob_Frm_ReturnProblems);
                ob_Frm_ReturnProblems.Show();
            }     
        }

        private void toolStripMenuItem修改机构_Click(object sender, EventArgs e)
        {
            Frm_修改机构 ob_Frm_AlterHospital = new Frm_修改机构();
            //SetFill(ob_Frm_AlterHospital);
            ob_Frm_AlterHospital.ShowDialog();
        }

        private void toolStripMenuItem修改密码_Click(object sender, EventArgs e)
        {
            Frm_AlterPasword ob_Frm_AlterPass = new Frm_AlterPasword();
            ob_Frm_AlterPass.ShowDialog();
        }

        private void timer_pub_Tick(object sender, EventArgs e)
        {
            tsslTime.Text = System.DateTime.Now.ToString();
        }

        private void btnSSGL_Click(object sender, EventArgs e)
        {
            lvMain.LargeImageList = imageList_SSGL;
            lvMain.Dock = DockStyle.None;
            btnSSGL.Dock = DockStyle.Top;
            btnCXTJ.Dock = DockStyle.Bottom;
            btnWZFY.SendToBack();
            btnWZFY.Dock = DockStyle.Bottom;
            btnXTXG.SendToBack();
            btnXTXG.Dock = DockStyle.Bottom;
            lvMain.BringToFront();
            lvMain.Dock = DockStyle.Bottom;
            lvMain.Clear();
            lvMain.Items.Add("手术申请", "手术申请", 0);
            lvMain.Items.Add("手术排班", "手术排班", 1);
            lvMain.Items.Add("护士排班", "护士排班", 2);
            lvMain.Items.Add("报告编辑", "报告编辑", 3);
            lvMain.Items.Add("申请单作废", "申请单作废", 4);
        }

        private void pnlMain_SizeChanged(object sender, EventArgs e)
        {
            lvMain.Height = pnlMain.Height - 4 * btnXTXG.Height;
        }

        private void btnWZFY_Click(object sender, EventArgs e)
        {
            lvMain.LargeImageList = imageList_WZFY;
            lvMain.Dock = DockStyle.None;
            btnWZFY.SendToBack();
            btnWZFY.Dock = DockStyle.Top;
            btnCXTJ.SendToBack();
            btnCXTJ.Dock = DockStyle.Top;
            btnSSGL.SendToBack();
            btnSSGL.Dock = DockStyle.Top;
            btnXTXG.Dock = DockStyle.Bottom;
            lvMain.BringToFront();
            lvMain.Dock = DockStyle.Bottom;
            lvMain.Clear();
            lvMain.Items.Add("药品申请", "药品申请", 0);
            lvMain.Items.Add("汇总领药", "汇总领药", 1);
            lvMain.Items.Add("材料补录", "材料补录", 2);
            lvMain.Items.Add("费用补录", "费用补录", 2);
            lvMain.Items.Add("费用冲减", "费用冲减", 3);
        }

        private void btnCXTJ_Click_1(object sender, EventArgs e)
        {
            lvMain.LargeImageList = imageList_CXTJ;
            lvMain.Dock = DockStyle.None;
            btnCXTJ.Dock = DockStyle.Top;
            btnSSGL.SendToBack();
            btnSSGL.Dock = DockStyle.Top;
            btnWZFY.Dock = DockStyle.Bottom;
            btnXTXG.Dock = DockStyle.Bottom;
            lvMain.BringToFront();
            lvMain.Dock = DockStyle.Bottom;
            lvMain.Clear();
            lvMain.Items.Add("手术单查询", "手术单查询", 0);
            lvMain.Items.Add("汇总领药查询", "汇总领药查询", 1);
            lvMain.Items.Add("护士排班表查询", "护士排班表查询", 2);
            lvMain.Items.Add("手术费用及人次统计", "手术费用及人次统计", 3);
            lvMain.Items.Add("手术项目费用及人次统计表", "手术项目费用及人次统计表", 4);
            lvMain.Items.Add("手术工作量统计", "手术工作量统计", 5);
            lvMain.Items.Add("病人手术费用查询", "病人手术费用查询", 6);
            lvMain.Items.Add("手术例数统计_按医生", "按医生", 7);
            lvMain.Items.Add("手术例数统计_按科室", "手术例数统计", 7);
            lvMain.Items.Add("手术费用统计", "手术费用统计", 8);
            lvMain.Items.Add("手术明细费用查询", "手术明细费用查询", 9);
        }

        private void btnXTXG_Click_1(object sender, EventArgs e)
        {
            lvMain.LargeImageList = imageList_XTXG;
            lvMain.Dock = DockStyle.None;
            btnXTXG.SendToBack();
            btnXTXG.Dock = DockStyle.Top;
            btnWZFY.SendToBack();
            btnWZFY.Dock = DockStyle.Top;
            btnCXTJ.SendToBack();
            btnCXTJ.Dock = DockStyle.Top;
            btnSSGL.SendToBack();
            btnCXTJ.Dock = DockStyle.Top;
            lvMain.Dock = DockStyle.Bottom;
            lvMain.Clear();
            lvMain.Items.Add("字典维护", "字典维护", 0);
            lvMain.Items.Add("系统参数", "系统参数", 1);
            lvMain.Items.Add("医嘱模板", "医嘱模板", 2);
            lvMain.Items.Add("系统通知", "系统通知", 3);
            lvMain.Items.Add("问题反馈", "问题反馈", 4);
            lvMain.Items.Add("锁定用户", "锁定用户", 5);
            lvMain.Items.Add("修改机构", "修改机构", 6);
            lvMain.Items.Add("修改密码", "修改密码", 7);
            lvMain.Items.Add("重启系统", "重启系统", 8);
            lvMain.Items.Add("关于", "关于", 9);
        }

        private void lvMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = lvMain.HitTest(e.X, e.Y);
            if (info.Item != null)
            {
                MessageBox.Show(info.Item.Text);
            } 
        }

        private void toolStripMenuItem系统参数_Click(object sender, EventArgs e)
        {
            if (HaveClosed(this, "Frm_SysParams"))
            {

                ob_Frm_SysParams = new Frm_系统参数();
                ob_Frm_SysParams.Name = "Frm_SysParams";
                ob_Frm_SysParams.MdiParent = this;
                SetFill(ob_Frm_SysParams);
                ob_Frm_SysParams.Show();
            }
            else
            {
                ob_Frm_SysParams.Show();
            }     
        }

        private void toolStripMenuItem字典维护_Click(object sender, EventArgs e)
        {
            if (HaveClosed(this, "Frm_字典维护"))
            {

                ob_Frm_字典维护 = new Frm_字典维护();
                ob_Frm_字典维护.Name = "Frm_字典维护";
                ob_Frm_字典维护.MdiParent = this;
                SetFill(ob_Frm_字典维护);
                ob_Frm_字典维护.Show();
            }
            else
            {
                ob_Frm_字典维护.Show();
            }  
        }

        private void toolStripMenuItem医嘱模板_Click(object sender, EventArgs e)
        {
            if (HaveClosed(this, "Frm_医嘱模板"))
            {

                ob_Frm_医嘱模板 = new Frm_医嘱模板();
                ob_Frm_医嘱模板.Name = "Frm_医嘱模板";
                ob_Frm_医嘱模板.MdiParent = this;
                SetFill(ob_Frm_医嘱模板);
                ob_Frm_医嘱模板.Show();
            }
            else
            {
                ob_Frm_医嘱模板.Show();
            }  
        }

        private void toolStripMenuItem手术申请_Click(object sender, EventArgs e)
        {
            if (HaveClosed(this, "Frm_手术申请"))
            {

                ob_Frm_手术申请 = new Frm_手术申请();
                ob_Frm_手术申请.Name = "Frm_手术申请";
                ob_Frm_手术申请.MdiParent = this;
                SetFill(ob_Frm_手术申请);
                ob_Frm_手术申请.Show();
            }
            else
            {
                ob_Frm_手术申请.Show();
            }  
        }

        private void toolStripMenuItem费用补录_Click(object sender, EventArgs e)
        {
            if (HaveClosed(this, "Frm_费用补录"))
            {

                ob_Frm_费用补录 = new Frm_费用补录();
                ob_Frm_费用补录.Name = "Frm_费用补录";
                ob_Frm_费用补录.MdiParent = this;
                SetFill(ob_Frm_费用补录);
                ob_Frm_费用补录.Show();
            }
            else
            {
                ob_Frm_费用补录.Show();
            }  
        }

        private void toolStripMenuItem费用冲减_Click(object sender, EventArgs e)
        {
            if (HaveClosed(this, "Frm_费用冲减"))
            {

                ob_Frm_费用冲减 = new Frm_费用冲减();
                ob_Frm_费用冲减.Name = "Frm_费用冲减";
                ob_Frm_费用冲减.MdiParent = this;
                SetFill(ob_Frm_费用冲减);
                ob_Frm_费用冲减.Show();
            }
            else
            {
                ob_Frm_费用冲减.Show();
            }  
        }

        private void toolStripMenuItem药品申请_Click(object sender, EventArgs e)
        {
            if (HaveClosed(this, "Frm_药品申请"))
            {

                ob_Frm_药品申请 = new Frm_药品申请();
                ob_Frm_药品申请.Name = "Frm_药品申请";
                ob_Frm_药品申请.MdiParent = this;
                SetFill(ob_Frm_药品申请);
                ob_Frm_药品申请.Show();
            }
            else
            {
                ob_Frm_药品申请.Show();
            } 
        }

        private void toolStripMenuItem汇总领药_Click(object sender, EventArgs e)
        {
            if (HaveClosed(this, "Frm_汇总领药"))
            {

                ob_Frm_汇总领药 = new Frm_汇总领药();
                ob_Frm_汇总领药.Name = "Frm_汇总领药";
                ob_Frm_汇总领药.MdiParent = this;
                SetFill(ob_Frm_汇总领药);
                ob_Frm_汇总领药.Show();
            }
            else
            {
                ob_Frm_汇总领药.Show();
            } 
        }

        private void toolStripMenuItem材料补录_Click(object sender, EventArgs e)
        {
            if (HaveClosed(this, "Frm_材料补录"))
            {

                ob_Frm_材料补录 = new Frm_材料补录();
                ob_Frm_材料补录.Name = "Frm_材料补录";
                ob_Frm_材料补录.MdiParent = this;
                SetFill(ob_Frm_材料补录);
                ob_Frm_材料补录.Show();
            }
            else
            {
                ob_Frm_材料补录.Show();
            } 
        }

        private void toolStripMenuItem手术排班_Click(object sender, EventArgs e)
        {
            if (HaveClosed(this, "Frm_手术排班"))
            {

                ob_Frm_手术排班 = new Frm_手术排班();
                ob_Frm_手术排班.Name = "Frm_手术排班";
                ob_Frm_手术排班.MdiParent = this;
                SetFill(ob_Frm_手术排班);
                ob_Frm_手术排班.Show();
            }
            else
            {
                ob_Frm_手术排班.Show();
            } 
        }

        private void toolStripMenuItem护士排班_Click(object sender, EventArgs e)
        {
            if (HaveClosed(this, "Frm_护士排班"))
            {

                ob_Frm_护士排班 = new Frm_护士排班();
                ob_Frm_护士排班.Name = "Frm_护士排班";
                ob_Frm_护士排班.MdiParent = this;
                SetFill(ob_Frm_护士排班);
                ob_Frm_护士排班.Show();
            }
            else
            {
                ob_Frm_护士排班.Show();
            } 
        }

        private void toolStripMenuItem报告编辑_Click(object sender, EventArgs e)
        {
            if (HaveClosed(this, "Frm_报告编辑"))
            {

                ob_Frm_报告编辑 = new Frm_报告编辑();
                ob_Frm_报告编辑.Name = "Frm_报告编辑";
                ob_Frm_报告编辑.MdiParent = this;
                SetFill(ob_Frm_报告编辑);
                ob_Frm_报告编辑.Show();
            }
            else
            {
                ob_Frm_报告编辑.Show();
            } 
        }

        private void toolStripMenuItem申请单作废_Click(object sender, EventArgs e)
        {
            if (HaveClosed(this, "Frm_申请单作废"))
            {

                ob_Frm_申请单作废 = new Frm_申请单作废();
                ob_Frm_申请单作废.Name = "Frm_申请单作废";
                ob_Frm_申请单作废.MdiParent = this;
                SetFill(ob_Frm_申请单作废);
                ob_Frm_申请单作废.Show();
            }
            else
            {
                ob_Frm_申请单作废.Show();
            } 
        }

        private void toolStripMenuItem手术单查询_Click(object sender, EventArgs e)
        {
            if (HaveClosed(this, "Frm_手术单查询"))
            {

                ob_Frm_手术单查询 = new Frm_手术单查询();
                ob_Frm_手术单查询.Name = "Frm_手术单查询";
                ob_Frm_手术单查询.MdiParent = this;
                SetFill(ob_Frm_手术单查询);
                ob_Frm_手术单查询.Show();
            }
            else
            {
                ob_Frm_手术单查询.Show();
            } 
        }

        private void toolStripMenuItem汇总领药查询_Click(object sender, EventArgs e)
        {
            if (HaveClosed(this, "Frm_汇总领药查询"))
            {

                ob_Frm_汇总领药查询 = new Frm_汇总领药查询();
                ob_Frm_汇总领药查询.Name = "Frm_汇总领药查询";
                ob_Frm_汇总领药查询.MdiParent = this;
                SetFill(ob_Frm_汇总领药查询);
                ob_Frm_汇总领药查询.Show();
            }
            else
            {
                ob_Frm_汇总领药查询.Show();
            } 
        }

        private void toolStripMenuItem护士排班表查询_Click(object sender, EventArgs e)
        {
            if (HaveClosed(this, "Frm_护士排班表查询"))
            {

                ob_Frm_护士排班表查询 = new Frm_护士排班表查询();
                ob_Frm_护士排班表查询.Name = "Frm_护士排班表查询";
                ob_Frm_护士排班表查询.MdiParent = this;
                SetFill(ob_Frm_护士排班表查询);
                ob_Frm_护士排班表查询.Show();
            }
            else
            {
                ob_Frm_护士排班表查询.Show();
            } 
        }

        private void toolStripMenuItem手术费用及人次统计_Click(object sender, EventArgs e)
        {
            if (HaveClosed(this, "Frm_手术费用及人次统计"))
            {

                ob_Frm_手术费用及人次统计 = new Frm_手术费用及人次统计();
                ob_Frm_手术费用及人次统计.Name = "Frm_手术费用及人次统计";
                ob_Frm_手术费用及人次统计.MdiParent = this;
                SetFill(ob_Frm_手术费用及人次统计);
                ob_Frm_手术费用及人次统计.Show();
            }
            else
            {
                ob_Frm_手术费用及人次统计.Show();
            } 
        }

        private void toolStripMenuItem手术项目费用及人次统计_Click(object sender, EventArgs e)
        {
            if (HaveClosed(this, "Frm_手术项目费用及人次统计"))
            {

                ob_Frm_手术项目费用及人次统计 = new Frm_手术项目费用及人次统计();
                ob_Frm_手术项目费用及人次统计.Name = "Frm_手术项目费用及人次统计";
                ob_Frm_手术项目费用及人次统计.MdiParent = this;
                SetFill(ob_Frm_手术项目费用及人次统计);
                ob_Frm_手术项目费用及人次统计.Show();
            }
            else
            {
                ob_Frm_手术项目费用及人次统计.Show();
            } 
        }

        private void toolStripMenuItem手术工作量统计_Click(object sender, EventArgs e)
        {
            if (HaveClosed(this, "Frm_手术工作量统计"))
            {

                ob_Frm_手术工作量统计 = new Frm_手术工作量统计();
                ob_Frm_手术工作量统计.Name = "Frm_手术工作量统计";
                ob_Frm_手术工作量统计.MdiParent = this;
                SetFill(ob_Frm_手术工作量统计);
                ob_Frm_手术工作量统计.Show();
            }
            else
            {
                ob_Frm_手术工作量统计.Show();
            } 
        }

        private void toolStripMenuItem病人手术费用查询_Click(object sender, EventArgs e)
        {
            if (HaveClosed(this, "Frm_病人手术费用查询"))
            {

                ob_Frm_病人手术费用查询 = new Frm_病人手术费用查询();
                ob_Frm_病人手术费用查询.Name = "Frm_病人手术费用查询";
                ob_Frm_病人手术费用查询.MdiParent = this;
                SetFill(ob_Frm_病人手术费用查询);
                ob_Frm_病人手术费用查询.Show();
            }
            else
            {
                ob_Frm_病人手术费用查询.Show();
            } 
        }

        private void toolStripMenuItem手术例数统计＿按医生_Click(object sender, EventArgs e)
        {
            if (HaveClosed(this, "Frm_手术例数统计＿按医生"))
            {

                ob_Frm_手术例数统计＿按医生 = new Frm_手术例数统计＿按医生();
                ob_Frm_手术例数统计＿按医生.Name = "Frm_手术例数统计＿按医生";
                ob_Frm_手术例数统计＿按医生.MdiParent = this;
                SetFill(ob_Frm_手术例数统计＿按医生);
                ob_Frm_手术例数统计＿按医生.Show();
            }
            else
            {
                ob_Frm_手术例数统计＿按医生.Show();
            } 
        }

        private void toolStripMenuItem手术例数统计＿按科室_Click(object sender, EventArgs e)
        {
            if (HaveClosed(this, "Frm_手术例数统计＿按科室"))
            {

                ob_Frm_手术例数统计＿按科室 = new Frm_手术例数统计＿按科室();
                ob_Frm_手术例数统计＿按科室.Name = "Frm_手术例数统计＿按科室";
                ob_Frm_手术例数统计＿按科室.MdiParent = this;
                SetFill(ob_Frm_手术例数统计＿按科室);
                ob_Frm_手术例数统计＿按科室.Show();
            }
            else
            {
                ob_Frm_手术例数统计＿按科室.Show();
            } 
        }

        private void toolStripMenuItem手术费用统计_Click(object sender, EventArgs e)
        {
            if (HaveClosed(this, "Frm_手术费用统计"))
            {

                ob_Frm_手术费用统计 = new Frm_手术费用统计();
                ob_Frm_手术费用统计.Name = "Frm_手术费用统计";
                ob_Frm_手术费用统计.MdiParent = this;
                SetFill(ob_Frm_手术费用统计);
                ob_Frm_手术费用统计.Show();
            }
            else
            {
                ob_Frm_手术费用统计.Show();
            } 
        }

        private void toolStripMenuItem手术明细费用查询_Click(object sender, EventArgs e)
        {
            if (HaveClosed(this, "Frm_手术明细费用查询"))
            {

                ob_Frm_手术明细费用查询 = new Frm_手术明细费用查询();
                ob_Frm_手术明细费用查询.Name = "Frm_手术明细费用查询";
                ob_Frm_手术明细费用查询.MdiParent = this;
                SetFill(ob_Frm_手术明细费用查询);
                ob_Frm_手术明细费用查询.Show();
            }
            else
            {
                ob_Frm_手术明细费用查询.Show();
            } 
        }


    }
}