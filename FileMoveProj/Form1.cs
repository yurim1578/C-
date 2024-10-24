using Infragistics.Win.UltraWinGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileMoveProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  
        private void btnRight_Click(object sender, EventArgs e)
        {
         
            foreach (UltraGridRow row in ultraGrid1.Rows)
            {
                if(row.Cells["체크"].Value.ToString().ToUpper().Equals("TRUE"))
                {
                    string filePath = txtStartPath.Value + @"\" + row.Cells["이름"].Value.ToString();
                    System.IO.FileInfo fi = new System.IO.FileInfo(filePath);
                    string name = row.Cells["이름"].Value.ToString();
                    bool bExist = true;
                    int indexOfDot = name.LastIndexOf(".");
                    string strName = name.Substring(0, indexOfDot);
                    string strExt = name.Substring(indexOfDot);
                    int fileCount = 0;

                    while (bExist)
                    {
                        if (File.Exists(txtEndPath.Value + @"\" + name))
                        {
                            fileCount++;
                            name = strName + "(" + fileCount + ")" + strExt;
                        }
                        else
                        {
                            bExist = false;
                        }
                    }
                    string endFilePath = txtEndPath.Value + @"\" +name;

                    int IBufferSize = 1024;
                    long ISize = 0;
                    long ITotalSize = fi.Length;
                    byte[] bTmp = new byte[IBufferSize];

                    System.IO.FileStream fsRead = new System.IO.FileStream(filePath, System.IO.FileMode.Open);
                    System.IO.FileStream fsWrite = new System.IO.FileStream(endFilePath, System.IO.FileMode.Create);

                    while (ISize < ITotalSize)
                    {
                        int iLen = fsRead.Read(bTmp, 0, bTmp.Length);
                        ISize += iLen;
                        fsWrite.Write(bTmp, 0, iLen);
                    }
                    fsWrite.Flush();
                    fsWrite.Close();
                    fsRead.Close();
                    File.Delete(filePath);/////////
                }
            }
             ultraGrid1.SetDataBinding(MakeTable(txtStartPath.Value.ToString()).Tables[0], null);
            ultraGrid2.SetDataBinding(MakeTable(txtEndPath.Value.ToString()).Tables[0], null);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            
            foreach (UltraGridRow row in ultraGrid2.Rows)
            {
                if (row.Cells["체크"].Value.ToString().ToUpper().Equals("TRUE"))
                {
                    string filePath = txtEndPath.Value + @"\" + row.Cells["이름"].Value.ToString();
                    System.IO.FileInfo fi = new System.IO.FileInfo(filePath);
                    string name = row.Cells["이름"].Value.ToString();
                    bool bExist = true;
                    int indexOfDot = name.LastIndexOf(".");
                    string strName = name.Substring(0, indexOfDot);
                    string strExt = name.Substring(indexOfDot);
                    int fileCount = 0;

                    while (bExist)
                    {
                        if (File.Exists(txtStartPath.Value + @"\" + name))
                        {
                            fileCount++;
                            name = strName + "(" + fileCount + ")" + strExt;
                        }
                        else
                        {
                            bExist = false;
                        }
                    }
                    string endFilePath = txtStartPath.Value + @"\" + name;

                    int IBufferSize = 1024;
                    long ISize = 0;
                    long ITotalSize = fi.Length;
                    byte[] bTmp = new byte[IBufferSize];

                    System.IO.FileStream fsRead = new System.IO.FileStream(filePath, System.IO.FileMode.Open);
                    System.IO.FileStream fsWrite = new System.IO.FileStream(endFilePath, System.IO.FileMode.Create);

                    while (ISize < ITotalSize)
                    {
                        int iLen = fsRead.Read(bTmp, 0, bTmp.Length);
                        ISize += iLen;
                        fsWrite.Write(bTmp, 0, iLen);
                    }
                    fsWrite.Flush();
                    fsWrite.Close();
                    fsRead.Close();
                    File.Delete(filePath);/////////
                }
            }
            ultraGrid1.SetDataBinding(MakeTable(txtStartPath.Value.ToString()).Tables[0], null);
            ultraGrid2.SetDataBinding(MakeTable(txtEndPath.Value.ToString()).Tables[0], null);
        }

        private void ultraGrid1_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
          
        }

        private void ultraGrid2_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
           
         
        }

        private DataSet MakeTable(string path)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add("View");

            ds.Tables[0].Columns.Add("체크", typeof(bool));
            ds.Tables[0].Columns.Add("이름", typeof(string));
            ds.Tables[0].Columns.Add("분류", typeof(string));
            ds.Tables[0].Columns.Add("크기", typeof(string));

            if (Directory.Exists(path))
            {
                string[] nowfile = Directory.GetFiles(path);
                string[] nowDir = Directory.GetDirectories(path);

                for (int i = 0; i < nowfile.Length; i++)
                {
                    DataRow row = ds.Tables[0].NewRow();
                    string[] str = nowfile[i].Split(Convert.ToChar(@"\"));
                    row["체크"] = false;
                    row["이름"] = str[str.Length - 1];
                    row["분류"] = "파일";
                    FileInfo info = new FileInfo(nowfile[i]);
                    row["크기"] = info.Length + "byte";

                    ds.Tables[0].Rows.Add(row);
                }
                for (int j = 0; j < nowDir.Length; j++)
                {
                    DataRow row = ds.Tables[0].NewRow();
                    string[] str = nowDir[j].Split(Convert.ToChar(@"\"));
                    row["체크"] = false;
                    row["이름"] = str[str.Length - 1];
                    row["분류"] = "디렉토리";
                    DirectoryInfo info = new DirectoryInfo(nowDir[j]);
                    long dirlength = 0;
                    foreach (FileInfo dir in info.GetFiles())
                    {
                        dirlength = dirlength + dir.Length;
                    }
                    row["크기"] = dirlength + "byte";

                    ds.Tables[0].Rows.Add(row);
                }   
            }

            return ds;
        }


        private void txtStartPath_AfterExitEditMode(object sender, EventArgs e)
        {
            DataTable dt = MakeTable(txtStartPath.Value.ToString()).Tables[0];
           
            ultraGrid1.SetDataBinding(dt, null);
           
        }

        private void txtEndPath_AfterExitEditMode(object sender, EventArgs e)
        {
            DataTable dt2 = MakeTable(txtEndPath.Value.ToString()).Tables[0];
            
            ultraGrid2.SetDataBinding(dt2, null);
        }
        
        
    }
}
