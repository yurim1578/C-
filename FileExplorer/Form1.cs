using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace FileExplorer
{
    public partial class Form1 : Form
    {
        private DataTable dt = new DataTable();
        Queue q = new Queue();
        Stack s = new Stack();
        public Form1()
        {
            InitializeComponent();
            
            dt.Columns.Add("이름", typeof(string));
            dt.Columns.Add("유형", typeof(string));
            dt.Columns.Add("용량", typeof(string));
        }

      
       
        private void SearchPath(string path)
        {            
            dt.Clear();
            //System.Security.Principal.WindowsIdentity identity = System.Security.Principal.WindowsIdentity.GetCurrent();
            //DriveInfo[] allDrives = DriveInfo.GetDrives(); //c,d
            //foreach (DriveInfo drive in allDrives)

            if (Directory.Exists(path))
            {
                string[] nowfile = Directory.GetFiles(path);
                string[] nowDir = Directory.GetDirectories(path);
                
                for (int i =0;i<nowfile.Length;i++)
                { 
                    DataRow row = dt.NewRow();
                    string[] str= nowfile[i].Split(Convert.ToChar(@"\"));
                    row["이름"] = str[str.Length - 1];
                    row["유형"] = "파일";
                    FileInfo info = new FileInfo(nowfile[i]);
                    row["용량"] = info.Length + "byte";

                    dt.Rows.Add(row);
                }
                for (int j = 0; j < nowDir.Length; j++)
                {
                    DataRow row = dt.NewRow();
                    string[] str = nowDir[j].Split(Convert.ToChar(@"\"));
                    row["이름"] = str[str.Length - 1];
                    row["유형"] = "디렉토리";
                    DirectoryInfo info = new DirectoryInfo(nowDir[j]);
                    long dirlength = 0;
                    foreach( FileInfo dir in info.GetFiles())
                    {
                        dirlength = dirlength + dir.Length;
                    }
                    row["용량"] = dirlength + "byte";

                    dt.Rows.Add(row);
                }
            }

            ultraGrid1.SetDataBinding(dt, null);
   

        }


        private void ultraGrid1_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        { 
            string path = txtRealPath.Value.ToString();
            SearchPath(path);
            s.Push(path);//
            q.Enqueue(path);
        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            try
            {
                string[] splitpath = txtRealPath.Value.ToString().Split(Convert.ToChar(@"\"));
                string path = string.Empty;
                for(int i = 0; i < splitpath.Length-1; i++)
                {
                    if (i != 0){
                        path +=@"\"+ splitpath[i];
                    }
                    else
                    {
                        path += splitpath[i];
                    }
                    
                }
                SearchPath(path);
                s.Push(path);
                q.Enqueue(path);
                txtRealPath.Value = path;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "확인", MessageBoxButtons.OK);
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            string prePath = s.Pop().ToString();
            q.Enqueue(prePath);
            SearchPath(prePath);
            txtRealPath.Value = prePath;
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            string postPath = q.Dequeue().ToString();            
            s.Push(postPath);
            SearchPath(postPath);
            txtRealPath.Value = postPath;
        }

        private void ultraGrid1_DoubleClickRow(object sender, Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs e)
        {
            string nextPath = txtRealPath.Value.ToString() + @"\" + e.Row.Cells["이름"].Value.ToString();
            if (Directory.Exists(nextPath))
            {
                SearchPath(nextPath);
                txtRealPath.Value = nextPath;
                s.Push(nextPath);
                q.Enqueue(nextPath);
            }
        }
    }
}
