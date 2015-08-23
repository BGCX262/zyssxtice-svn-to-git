using System;
using System.Collections.Generic;
using System.Text;

using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Xml;
using System.Data.OleDb;
using System.Collections;
using Microsoft.Office.Core;
using Excel;
using VBIDE;
using GemBox.ExcelLite;
using System.Security.Cryptography;
//using CrystalDecisions.CrystalReports.Engine;
//using CrystalDecisions.Shared;
//using CrystalDecisions.Windows;

namespace Form_Pub
{
    class Pub_Data
    {
        // 声明INI文件的写操作函数 WritePrivateProfileString()
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        // 声明INI文件的读操作函数 GetPrivateProfileString()
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, System.Text.StringBuilder retVal, int size, string filePath);

        [DllImport("USER32.DLL")]
        private static extern int GetSystemMenu(int hwnd, int bRevert);

        [DllImport("USER32.DLL")]
        private static extern int RemoveMenu(int hMenu, int nPosition, int wFlags);

        public const string conn_DataSource = ".";
        public const string conn_InitialCatalog = "BUY_BOOK";
        public const bool conn_IntegratedSecurity = true;
        public static SqlConnection conn = new SqlConnection(getconStr());

        #region 监听系统键盘
        /// <summary>
        /// 监听系统键盘
        /// </summary>
        public class HotKey
        {
            //如果函数执行成功，返回值不为0。  
            //如果函数执行失败，返回值为0。要得到扩展错误信息，调用GetLastError。  
            [DllImport("user32.dll", SetLastError = true)]
            public static extern bool RegisterHotKey(
                IntPtr hWnd,                //要定义热键的窗口的句柄  
                int id,                     //定义热键ID（不能与其它ID重复）             
                KeyModifiers fsModifiers,   //标识热键是否在按Alt、Ctrl、Shift、Windows等键时才会生效  
                Keys vk                     //定义热键的内容  
                );

            [DllImport("user32.dll", SetLastError = true)]
            public static extern bool UnregisterHotKey(
                IntPtr hWnd,                //要取消热键的窗口的句柄  
                int id                      //要取消热键的ID  
                );

            //定义了辅助键的名称（将数字转变为字符以便于记忆，也可去除此枚举而直接使用数值）  
            [Flags()]
            public enum KeyModifiers
            {
                None = 0,
                Alt = 1,
                Ctrl = 2,
                Shift = 4,
                WindowsKey = 8
            }

        }
        #endregion

        #region 移除窗体关闭按钮
        /// <summary>
        /// 返回值，非零表示成功，零表示失败。
        /// </summary>
        /// <param name="iHWND">窗口的句柄</param>
        /// <returns>是否成功</returns>
        public static  int RemoveXButton(int iHWND)
        {
            int iSysMenu;
            const int MF_BYCOMMAND = 0x400; //0x400-关闭
            iSysMenu = GetSystemMenu(iHWND, 0);
            return RemoveMenu(iSysMenu, 6, MF_BYCOMMAND);
        }
        #endregion

        #region　保存到ini文件
        /// <summary>
        /// 保存到ini文件。
        /// </summary>
        /// <param name="section">块</param>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        /// <param name="filename">存放路径</param
        /// <returns>是否成功</returns>
        public static bool SaveToIniFile(string section, string key, string value, string filename)
        {
            /*example:
              
            
                FilePath = Application.StartupPath + @"\ICE_DB.ini";
                // section=配置节，key=键名，value=键值，FilePath=路径
                string section = "数据库连接字符串";
                string key = "ConnectionStr";
                string value = txtConnectionStr.Text;
                WritePrivateProfileString(section, key, value, FilePath);
                MessageBox.Show("数据库连接成功备份啦~~", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
             */
            WritePrivateProfileString(section, key, value, filename);
            return true;
        }
        #endregion

        #region　读取ini文件
        /// <summary>
        ///读取ini文件。
        /// </summary>
        /// <param name="section">块</param>
        /// <param name="key">键</param>
        /// <param name="filename">存放路径</param>
        /// <returns>值</returns>
        public static string GetFromIniFile(string section, string key, string filename)
        {
            /*example:
              
            FilePath = Application.StartupPath + @"\ICE_DB.ini";
            System.Text.StringBuilder temp = new System.Text.StringBuilder(1024);
            // section=配置节，key=键名，temp=上面，FilePath=路径
            string section = "数据库连接字符串";
            string key = "ConnectionStr";
            GetPrivateProfileString(section, key, "", temp, 255, FilePath);
            txtConnectionStr.Text = temp.ToString();
            MessageBox.Show("数据库连接成功恢复啦~~", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
             */
            System.Text.StringBuilder temp = new System.Text.StringBuilder(1024);
            GetPrivateProfileString(section, key, "", temp, 255, filename);
            return temp.ToString();
        }
        #endregion

        

        #region 获取连接字符串
        ///<summary>
        ///获取连接字符串
        ///</summary>
        public static string getconStr()
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = conn_DataSource;
            scsb.InitialCatalog = conn_InitialCatalog;
            //scsb.UserID = "sa";
            //scsb.Password = "123";
            scsb.IntegratedSecurity = conn_IntegratedSecurity;
            return scsb.ConnectionString;
        }
        #endregion

        #region 执行指定的SQL语句，返回数据表DataTable
        ///<summary>
        ///执行指定的SQL语句，返回数据表DataTable
        ///</summary>
        ///<param name="strSQL">指定的SQL语句</param>
        ///<param name="strConn">连接字符串</param>
        public static System.Data.DataTable GetDataFromDBToDatatable(string strSQL, string strConn)
        {

            System.Data.DataTable dt = new System.Data.DataTable();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = strConn;
                conn.Open();
                using (SqlDataAdapter sda = new SqlDataAdapter(strSQL, conn))
                {
                    sda.Fill(dt);
                }
            }

            return dt;
        }
        #endregion

        #region 执行指定的SQL语句，返回结果集DataSet
        ///<summary>
        ///执行指定的SQL语句，返回结果集DataSet
        ///</summary>
        ///<param name="strSQL">指定的SQL语句</param>
        ///<param name="strConn">连接字符串</param>
        public static DataSet GetDataFromDBToDataset(string sqlStr, string strConn)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = strConn;
                conn.Open();

                SqlDataAdapter myAdapter = new SqlDataAdapter(sqlStr, strConn);
                DataSet myDataSet = new DataSet();
                myDataSet.Clear();
                myAdapter.Fill(myDataSet);
                conn.Close();
                if (myDataSet.Tables[0].Rows.Count != 0)
                {
                    return myDataSet;
                }
                else
                {
                    return null;
                }
            }

        }
        #endregion

        #region 执行指定的SQL语句，“写”数据到数据库，返回bool值
        ///<summary>
        ///执行指定的SQL语句，“写”数据到数据库，返回bool值
        ///</summary>
        ///<param name="strSQL">指定的SQL语句</param>
        ///<param name="strConn">连接字符串</param>
        public static bool UpdateDB(string sqlStr, string strConn)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = strConn;
                conn.Open();
                // 定义数据命令对象
                SqlCommand myCmd = new SqlCommand(sqlStr, conn);
                // 设置Command对象的CommandType属性
                myCmd.CommandType = CommandType.Text;
                // 执行SQL语句
                myCmd.ExecuteNonQuery();
                conn.Close();
                // 数据更新成功,返回true
                return true;
            }

        }
        #endregion

        #region 执行指定的SQL语句，事务——“写”数据到数据库，返回bool值
        ///<summary>
        ///执行指定的SQL语句，事务——“写”数据到数据库，返回bool值
        ///</summary>
        ///<param name="strSQL">指定的SQL语句</param>
        ///<param name="strConn">连接字符串</param>
        public static bool UpdateDB_ByTransaction(string sqlStr, string strConn)
        {

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = strConn;
                conn.Open();
                // 定义数据命令对象
                SqlCommand myCmd = new SqlCommand(sqlStr, conn);
                SqlTransaction tran = conn.BeginTransaction();
                myCmd.Transaction = tran;
                // 设置Command对象的CommandType属性
                myCmd.CommandType = CommandType.Text;
                try
                {

                    // 执行SQL语句
                    myCmd.ExecuteNonQuery();
                    conn.Close();
                    // 数据更新成功,返回true
                    tran.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    tran.Rollback();
                    return false;
                }

            }

            /*
            SqlConnection Conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand(sqlStr);
            Conn.Open();
            SqlTransaction tran = Conn.BeginTransaction();
            cmd.Transaction = tran;
            try
            {
                MessageBox.Show(cmd.ExecuteNonQuery().ToString());
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    tran.Commit();
                    return true;
                }
            }
            catch
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                Conn.Close();
            }

            return false;*/
        }
        #endregion


        #region 执行指定的SQL语句，计算新的编号，输出格式---“20110000001”（门诊挂号）
        ///<summary>
        ///执行指定的SQL语句，计算新的编号，输出格式---“20110000001”（门诊挂号）
        ///</summary>
        ///<param name="sql">指定的SQL语句</param>
        ///<param name="connstr">连接字符串</param>
        public static string CreateNewID(string sql, string connstr)
        {
            SqlConnection cn = new SqlConnection(connstr);
            cn.Open();
            SqlCommand cmb = cn.CreateCommand();
            cmb.CommandText = sql;
            string result;
            if (cmb.ExecuteScalar() != System.DBNull.Value)//System.DBNull.Value是指数据库中空值
            {
                result = cmb.ExecuteScalar().ToString().Trim();
            }
            else
            {
                return (System.DateTime.Now.Year.ToString() + "0000001");//命名规则为年份+7位编号
            }

            result = result.Substring(4, 7);
            int newID = Convert.ToInt32(result) + 1;
            int length = newID.ToString().Length;
            string returnStr = System.DateTime.Now.Year.ToString();
            switch (length)//生成新的编码
            {
                case 1:
                    returnStr += "000000" + newID.ToString();
                    break;
                case 2:
                    returnStr += "00000" + newID.ToString();
                    break;
                case 3:
                    returnStr += "0000" + newID.ToString();
                    break;
                case 4:
                    returnStr += "000" + newID.ToString();
                    break;
                case 5:
                    returnStr += "00" + newID.ToString();
                    break;
                case 6:
                    returnStr += "0" + newID.ToString();
                    break;
                case 7:
                    returnStr += newID.ToString();
                    break;
            }
            return (returnStr);
        }
        #endregion


        #region 执行指定的SQL语句，计算新的编号，输出格式---“0000001”（学号）
        ///<summary>
        ///执行指定的SQL语句，计算新的编号，输出格式---“0000001”（学号）
        ///</summary>
        ///<param name="sql">指定的SQL语句</param>
        ///<param name="connstr">连接字符串</param>
        public static string CreateNewAccountID(string sql, string connstr)
        {
            SqlConnection cn = new SqlConnection(connstr);
            cn.Open();
            SqlCommand cmb = cn.CreateCommand();
            cmb.CommandText = sql;
            string result;
            if (cmb.ExecuteScalar() != System.DBNull.Value)//System.DBNull.Value是指数据库中空值
            {
                result = cmb.ExecuteScalar().ToString().Trim();
            }
            else
            {
                return ("0000001");//命名规则为7位编号
            }

            //result = result.Substring(4, 7);
            int newID = Convert.ToInt32(result) + 1;
            int length = newID.ToString().Length;
            string returnStr = "";
            switch (length)//生成新的编码
            {
                case 1:
                    returnStr += "000000" + newID.ToString();
                    break;
                case 2:
                    returnStr += "00000" + newID.ToString();
                    break;
                case 3:
                    returnStr += "0000" + newID.ToString();
                    break;
                case 4:
                    returnStr += "000" + newID.ToString();
                    break;
                case 5:
                    returnStr += "00" + newID.ToString();
                    break;
                case 6:
                    returnStr += "0" + newID.ToString();
                    break;
                case 7:
                    returnStr += newID.ToString();
                    break;
            }
            return (returnStr);
        }
        #endregion


        #region 执行指定的SQL语句，计算新的编号，输出格式---“0000000001”（流水号）
        ///<summary>
        ///执行指定的SQL语句，计算新的编号，输出格式---“0000000001”（流水号）
        ///</summary>
        ///<param name="sql">指定的SQL语句</param>
        ///<param name="connstr">连接字符串</param>
        public static string CreateNewOderId(string sql, string connstr)
        {
            SqlConnection cn = new SqlConnection(connstr);
            cn.Open();
            SqlCommand cmb = cn.CreateCommand();
            cmb.CommandText = sql;
            string result;
            if (cmb.ExecuteScalar() != System.DBNull.Value)//System.DBNull.Value是指数据库中空值
            {
                result = cmb.ExecuteScalar().ToString().Trim();
            }
            else
            {
                return ("000000001");//命名规则为年份+7位编号
            }

            int newOderNum = Convert.ToInt32(result) + 1;
            int length = newOderNum.ToString().Length;
            string returnStr = "";
            switch (length)//生成新的编码
            {
                case 1:
                    returnStr = "00000000" + newOderNum.ToString();
                    break;
                case 2:
                    returnStr = "0000000" + newOderNum.ToString();
                    break;
                case 3:
                    returnStr = "000000" + newOderNum.ToString();
                    break;
                case 4:
                    returnStr = "00000" + newOderNum.ToString();
                    break;
                case 5:
                    returnStr = "0000" + newOderNum.ToString();
                    break;
                case 6:
                    returnStr = "000" + newOderNum.ToString();
                    break;
                case 7:
                    returnStr = "00" + newOderNum.ToString();
                    break;
                case 8:
                    returnStr = "0" + newOderNum.ToString();
                    break;
                case 9:
                    returnStr = newOderNum.ToString();
                    break;
            }
            return (returnStr);
        }
        #endregion


        #region 执行指定的SQL语句，计算新的编号和小项编号，输出格式---“0000000001”（流水号）
        ///<summary>
        ///执行指定的SQL语句，计算新的编号和小项编号，输出格式---“0000000001”（流水号）
        /// ---------在新增处方时，根据sql语句计算并设置新的处方编号编号和小项编号---------
        ///</summary>
        ///<param name="sql">指定的SQL语句</param>
        ///<param name="connstr">连接字符串</param>
        public static int CreateNewIntID(string sql, string connstr)
        {
            SqlConnection cn = new SqlConnection(connstr);
            cn.Open();
            SqlCommand cmb = cn.CreateCommand();
            cmb.CommandText = sql;
            string result;
            if (cmb.ExecuteScalar() != System.DBNull.Value)//System.DBNull.Value是指数据库中空值
            {
                result = cmb.ExecuteScalar().ToString().Trim();
            }
            else
            {
                return (1);//命名规则为年份+7位编号
            }
            int newID = Convert.ToInt32(result) + 1;
            return (newID);
        }

        #endregion

        #region XML----读取xml中某个节点的值，用于读取授权机构
        ///<summary>
        ///读取xml中某个节点的值，用于读取授权机构
        ///</summary>
        ///<paramname="path">xml文件路径</param>
        public static string xmlreadHospital(string path)
        {
            XmlTextReader reader = new XmlTextReader(path);
            while (reader.Read())
            {
                if (reader.LocalName.Equals("HospitalName"))
                {
                    return reader.ReadString();
                }
            }
            return "";
        }
        #endregion


        #region XML----设置xml中某个节点的值，用于设置授权机构
        ///<summary>
        ///设置xml中某个节点的值，用于设置授权机构
        ///</summary>
        ///<param name="path">xml文件路径</param>
        ///<param name="newText">新的节点值</param>
        public static void xmlwriteHospital(string path, string newText)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNodeList nls = doc.ChildNodes;//继续获取子节点的所有子节点         
            foreach (XmlNode xn1 in nls)//遍历         
            {
                if (xn1.Name == "HospitalName")//如果找到              
                {
                    xn1.InnerText = newText;//则修改
                    doc.Save(path);//保存。
                    break;//找到退出来就可以了              
                }

                foreach (XmlNode xn2 in xn1.ChildNodes)
                {
                    if (xn2.Name == "HospitalName")//如果找到              
                    {
                        xn2.InnerText = newText;//则修改  
                        doc.Save(path);//保存。
                        break;//找到退出来就可以了              
                    }
                    foreach (XmlNode xn3 in xn2.ChildNodes)
                    {

                        if (xn3.Name == "HospitalName")//如果找到              
                        {

                            xn3.InnerText = newText;//则修改
                            doc.Save(path);//保存。
                            break;//找到退出来就可以了              
                        }
                    }
                }

            }
        }
        #endregion

        #region 选取当前最新的记录，返回结果集DataSet
        ///<summary>
        ///选取当前最新的记录，返回结果集DataSet
        ///</summary>
        ///<param name="patientId">病人编号</param>
        public static DataSet SelectLastRegId(string patientId)
        {
            DataSet ds = new DataSet();
            try
            {
                string connstr = getconStr();
                string sqlstr = "select regId,regDate from tb_register where regId = (select max(regId) from tb_register where patientId='" + patientId + "')";
                //string sqlstr = "select max(regId),max(regDate) from tb_register  where patientId='" + patientId + "'";                
                ds = GetDataFromDBToDataset(sqlstr, connstr);
                if (ds != null)
                {
                    return ds;
                }
                else
                {
                    MessageBox.Show("没有查到最新挂号");
                }

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return ds;
            }
        }
        #endregion

        #region ICE----产生9位验证码，返回string
        ///<summary>
        ///产生9位验证码，返回string
        ///</summary>
        public static string CheckCode()
        {
            int number;
            char code;
            string checkCode = string.Empty;
            Random random = new Random();
            for (int i = 0; i < 9; i++)
            {
                number = random.Next();
                if (number % 2 == 0)
                {
                    code = (char)('0' + (char)(number % 10));//产生0--9的数字
                }
                else
                {
                    code = (char)('A' + (char)(number % 26));//产生A--Z的字母
                }
                checkCode += " " + code.ToString();
            }
            return checkCode;
        }
        #endregion

        #region ICE----比较2副图片是否相同，返回bool
        ///<summary>
        ///比较2副图片是否相同，返回bool
        ///</summary>
        ///<param name="image1">图片1</param>
        ///<param name="image2">图片2</param>
        public static bool SameImage(Image image1, Image image2)
        {
            MemoryStream ms1 = new MemoryStream();
            MemoryStream ms2 = new MemoryStream();

            image1.Save(ms1, System.Drawing.Imaging.ImageFormat.Bmp);
            image2.Save(ms2, System.Drawing.Imaging.ImageFormat.Bmp);
            byte[] im1 = ms1.GetBuffer();
            byte[] im2 = ms2.GetBuffer();
            if (im1.Length != im2.Length)
                return false;
            else
            {
                for (int i = 0; i < im1.Length; i++)
                    if (im1[i] != im2[i])
                        return false;
            }
            return true;
        }
        #endregion


        #region CRP----水晶报表操作
        ///<summary>
        ///比较2副图片是否相同，返回bool
        ///</summary>
        ///<param name="image1">图片1</param>
        ///<param name="image2">图片2</param>
        //===========================水晶报表操作=====================================================
        /*
        ReportDocument doc = new ReportDocument();//新建报表对象
        private void FrmCrystalReport_Load(object sender, EventArgs e)
        {

            doc.Load(Application.StartupPath + "\\CrystalReport1.rpt");

            //TextObject txtTitle = (TextObject)doc.ReportDefinition.ReportObjects["Title"];//获取水晶报表里面的变量
            //txtTitle.Text += "相当不错";//对水晶报表里面的变量赋值
            TableLogOnInfo info = new TableLogOnInfo();
            info.ConnectionInfo.DatabaseName = "BUY_BOOK";
            info.ConnectionInfo.ServerName = ".";
            //info.ConnectionInfo.Password = "123";         
            //info.ConnectionInfo.UserID = "sa";
            info.ConnectionInfo.IntegratedSecurity = true;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in doc.Database.Tables)
            {
                table.ApplyLogOnInfo(info); //不需要用户登录
            }

            //注意字段名称要遵照水晶报表里的语法规则 表名.字段 ，语句要符合当前数据库的语法
            //此代码段放在CrystalReportViewer1.ReportSource = myReport;前后均可
            //doc.RecordSelectionFormula = "GroupName ({tb_Buy.BuyId}) =  '" + User_All.buyId + "'";//过滤条件
            doc.SetParameterValue("FilterBuyId", User_All.buyId);//传入一个Buyid到水晶报表里面的变量，过滤条件


            this.crystalReportViewer1.ReportSource = doc;
            //crystalReport1.SetParameterValue("Parm", "1");
            //crystalReportViewer1.ReportSource = crystalReport1;

            
           //ParameterFields paramFields = new ParameterFields();
          // ParameterField paramField = new ParameterField();
          // ParameterDiscreteValue discreteVal = new ParameterDiscreteValue();
           //paramField.ParameterFieldName = "FilterBuyId";
          // discreteVal.Value = "20110000001";
          // paramField.CurrentValues.Add(discreteVal);
          // paramFields.Add(paramField);
           //crystalReportViewer1.ParameterFieldInfo = paramFields; 
            

        }*/


        /*
        //静态报表
        public static ReportDocument doc_bill = new ReportDocument();//新建报表对象
        //初始化报表的方法
        public static ReportDocument Init_Cry_rep_bill()
        {
            ReportDocument doc = new ReportDocument();//新建报表对象
            doc.Load(Application.StartupPath + "\\CrystalReport_bill2.rpt");
            TableLogOnInfo info = new TableLogOnInfo();
            info.ConnectionInfo.DatabaseName = Pub_Data.conn_InitialCatalog;
            info.ConnectionInfo.ServerName = Pub_Data.conn_DataSource;
            //info.ConnectionInfo.Password = "123";         
            //info.ConnectionInfo.UserID = "sa";
            info.ConnectionInfo.IntegratedSecurity = Pub_Data.conn_IntegratedSecurity;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in doc.Database.Tables)
            {
                table.ApplyLogOnInfo(info); //不需要用户登录
            }
            return doc;
        }
        */
        #endregion


        #region 加密----使用MD5加密字符串的方法，返回string
        ///<summary>
        /// 使用MD5加密字符串的方法，返回string
        ///</summary>
        ///<param name="myString">需要加密的字符串</param>
        public static string GetMd5Str(string myString)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            // 获取字符串对应的字符数组
            byte[] fromData = System.Text.Encoding.Unicode.GetBytes(myString);
            // 获取哈希字符串数组
            byte[] toData = md5.ComputeHash(fromData);
            string byteStr = null;
            for (int i = 0; i < toData.Length; i++)
            {
                // 将字符数组连接还原成字符串,以十六进制的方式表示,不带前导"0x"
                byteStr += toData[i].ToString("x");
            }
            return byteStr;
        }
        #endregion

        #region Excel----加载指定Excel 到dataset，返回dataset
        ///<summary>
        /// 加载指定Excel 到dataset，返回dataset
        ///</summary>
        ///<param name="filePath">excel的路径</param>
        public static DataSet LoadDataFromExcel(string filePath)
        {
            try
            {
                string strConn;
                strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=False;IMEX=1'";
                OleDbConnection OleConn = new OleDbConnection(strConn);
                OleConn.Open();
                String sql = "SELECT * FROM  [Sheet1$]";//可是更改Sheet名称，比如sheet2，等等 

                OleDbDataAdapter OleDaExcel = new OleDbDataAdapter(sql, OleConn);
                DataSet OleDsExcle = new DataSet();
                OleDaExcel.Fill(OleDsExcle, "Sheet1");
                OleConn.Close();
                return OleDsExcle;
            }
            catch (Exception err)
            {
                MessageBox.Show("数据绑定Excel失败!失败原因：" + err.Message, "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }
        #endregion


        #region Excel----将Users表中的数据导出到指定filepath的Excel中，需要用到GemBox.ExcelLite;
        /// <summary>        
        /// 将Users表中的数据导出到指定filepath的Excel中，需要用到GemBox.ExcelLite;       
        /// /// </summary>
        ///<param name="dataGridView1">excel的路径</param>
        ///<param name="filePath">保存excel的路径</param>
        public static void Export_to_Excel(DataGridView dataGridView1, string filepath)
        {
            ExcelFile excelFile = new ExcelFile();
            ExcelWorksheet sheet = excelFile.Worksheets.Add("Users");
            int columns = dataGridView1.Columns.Count;
            int rows = dataGridView1.Rows.Count;
            for (int j = 0; j < columns; j++)
            {
                sheet.Cells[0, j].Value = dataGridView1.Columns[j].HeaderText;
            }
            for (int i = 1; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sheet.Cells[i, j].Value = dataGridView1[j, i - 1].Value.ToString().Trim();
                }
            }
            excelFile.SaveXls(@filepath);
            MessageBox.Show("生成成功");
        }
        #endregion

        #region Excel----根据excel的文件的路径提取其中表的数据,并且显示在datagridview中
        ///<summary>
        ///根据excel的文件的路径提取其中表的数据,并且显示在datagridview中
        ///</summary>
        ///<param name="Path">Excel文件的路径</param>
        ///<param name="dataGridView1">窗体中的dataGridView</param>
        public static void GetDataFromExcelWithAppointSheetName(DataGridView dataGridView1, string Path)
        {
            //连接串
            string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + Path + ";" + "Extended Properties='Excel 8.0;HDR=false;IMEX=1'";//HRD=false表示把标题算一行，HRD=NO表示不算做一行
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            //返回Excel的架构，包括各个sheet表的名称,类型，创建时间和修改时间等　
            System.Data.DataTable dtSheetName = conn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

            //包含excel中表名的字符串数组
            string[] strTableNames = new string[dtSheetName.Rows.Count];
            for (int k = 0; k < dtSheetName.Rows.Count; k++)
            {
                strTableNames[k] = dtSheetName.Rows[k]["TABLE_NAME"].ToString();
            }
            OleDbDataAdapter myCommand = null;
            System.Data.DataTable dt = new System.Data.DataTable();
            //从指定的表明查询数据,可先把所有表明列出来供用户选择
            string strExcel = "select*from[" + strTableNames[0] + "]";
            myCommand = new OleDbDataAdapter(strExcel, strConn);
            dt = new System.Data.DataTable();
            myCommand.Fill(dt);
            dataGridView1.DataSource = dt;//绑定到界面
        }
        #endregion

        #region 备份----备份数据库到指定backupPath
        ///<summary>
        ///备份数据库到指定backupPath
        ///</summary>
        ///<param name="backupPath">保存备份的路径</param>
        public static void BackUp_DB(string backupPath)
        {
            try
            {
                if (backupPath == "")
                {
                    MessageBox.Show("请先选择数据库备份路径", "提示");
                    return;
                }
                if (File.Exists(backupPath))
                {
                    File.Delete(backupPath);
                }
                string sqlStr;
                sqlStr = "backup database " + conn_InitialCatalog + " to disk='" + backupPath + " '";
                SqlCommand sqlCom = new SqlCommand(sqlStr, Pub_Data.conn);
                Pub_Data.conn.Open();
                sqlCom.ExecuteNonQuery();
                Pub_Data.conn.Close();
                if (MessageBox.Show("数据库备份成功", "提示",
                MessageBoxButtons.OK) == DialogResult.OK)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Pub_Data.conn.Close();
            }
        }
        #endregion

        #region 恢复----从指定restorePath恢复数据库
        ///<summary>
        ///从指定restorePath恢复数据库
        ///</summary>
        ///<param name="restorePath">备份文件所处的路径</param>
        public static void Restore_DB(string restorePath)
        {
            try
            {
                if (restorePath == "")
                {
                    MessageBox.Show("请先选择数据库恢复路径", "提示");
                    return;
                }
                // 以下代码用于关闭正在使用数据库的进程
                string conStr = "Data Source=.;Database=master;Integrated Security=True";//新建连接,避免使用之前的连接
                Pub_Data.conn.ConnectionString = conStr;
                Pub_Data.conn.Open();
                string sqlStr = "select spid from master..sysprocesses where dbid=db_id( '" + conn_InitialCatalog + "') ";
                SqlDataAdapter sda = new SqlDataAdapter(sqlStr, Pub_Data.conn);
                System.Data.DataTable spidTable = new System.Data.DataTable();
                sda.Fill(spidTable);
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = Pub_Data.conn;
                for (int iRow = 0; iRow <= spidTable.Rows.Count - 1; iRow++)
                {
                    // 强行关闭用户进程
                    cmd1.CommandText = "kill " + spidTable.Rows[iRow][0].ToString();
                    cmd1.ExecuteNonQuery();
                }
                Pub_Data.conn.Close();
                Pub_Data.conn.Dispose();
                string restoreStr = "use master restore database " + conn_InitialCatalog + " from disk='" + restorePath + " '";
                Pub_Data.conn.ConnectionString = conStr;
                Pub_Data.conn.Open();
                SqlCommand cmd2 = new SqlCommand(restoreStr, Pub_Data.conn);
                cmd2.ExecuteNonQuery();
                Pub_Data.conn.Close();
                if (MessageBox.Show("数据库恢复成功", "提示", MessageBoxButtons.OK) ==
                DialogResult.OK)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Pub_Data.conn.Close();
            }
        }
        #endregion

    }
}
