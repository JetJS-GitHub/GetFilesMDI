using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace GetFilesMDI
{
    public partial class MotherForm : Form
    {
        public MotherForm()
        {
            InitializeComponent();
        }

        private void btnGetFile_Click(object sender, EventArgs e)
        {
            if (ReDown_Zcfzb_163() == true)
            {
                MessageBox.Show("Download Files Succeed");
            }else
	        {
                MessageBox.Show("Download Files Failed");
            }
        }

        private bool ReDown_Zcfzb_163()//通过163把资产负责表文件下载到本地目录，文件名为000002zcfzb.csv
        {
            string[] sStockCode = new string[] { "600036", "600282", "000100", "300100" };
            //string sThisStockDir = "600036";
            //string sZcfzbName = "600036.csv";


            try
            {
                for (int i = 0; i < sStockCode.Length; i++)
                {
                    string sDownURIHead = "http://quotes.money.163.com/service/zcfzb_";
                    string sURIMiddle = sStockCode[i];
                    string sURITail = ".html";

                    string sZcfzbName = sStockCode[i] +".csv";
                    string sThisStockDir = sStockCode[i];

                    string sDownURI = sDownURIHead + sURIMiddle + sURITail;//得到下载地址。

                    string sDir = System.IO.Path.Combine(Directory.GetCurrentDirectory(), sThisStockDir);
                    string sFullFileName = System.IO.Path.Combine(sDir, sZcfzbName);
                    if (!Directory.Exists(sDir))
                    {
                        Directory.CreateDirectory(sDir);
                    }
                    if (File.Exists(sFullFileName))
                    {
                        if (File.Exists(sFullFileName + ".bak"))
                        {
                            File.Delete(sFullFileName + ".bak");
                        }
                        File.Move(sFullFileName, sFullFileName + ".bak");
                    }
                    WebClient Wc = new WebClient();
                    Application.DoEvents();
                    Wc.DownloadFile(sDownURI, sFullFileName);
                    Wc.Dispose();
                    Application.DoEvents();
                    LbStatus.Text = sDownURI + " Download to " + sFullFileName;
                    MessageBox.Show("Download" + sStockCode[i].ToString() + "succeed.");
                    //SiLogger.AppendLog(sDownURI + " Download to " + sFullFileName);
                }

            }
            catch (System.Exception ex)
            {
                //SiLogger.AppendLog("_163_DownloadZcfzb Error: " + sStockCode + " " + ex.Message);
                MessageBox.Show("_163_DownloadZcfzb Error: " + sStockCode + " " + ex.Message);
                return false;
            }
            return true;
        }

    }
}
