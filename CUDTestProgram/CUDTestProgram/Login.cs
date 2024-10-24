using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUDTestProgram
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            txtDBnm.Text = "";
            txtID.Text = "";
            txtIP.Text = "";
            txtPW.Text = "";
            txtTable.Text = "";

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string DBnm = txtDBnm.Text.ToString().Trim();
            string uid = txtID.Text.ToString().Trim();
            string ip = txtIP.Text.ToString().Trim();
            string pw = txtPW.Text.ToString().Trim();
            string tblnm = txtTable.Text.ToString().Trim();
            try
            {
                if (!ValidateIPv4(ip))
                {
                    MessageBox.Show("IP형식이 올바르지 않습니다.", "경고", MessageBoxButtons.OK);
                    return;
                }

                DataConnector dc = new DataConnector();

                if (dc.Verification(uid, pw, tblnm, DBnm, ip))
                {
                    Hide();

                    var tblInfo = new TableInfo(dc.connection, tblnm, DBnm);
                    //tblInfo.ShowDialog();   //제어권을 넘길수있는것그래서 다음 코드를 실행시킴    //show는 각자도생

                    if (tblInfo.ShowDialog() != DialogResult.OK)    //show dialog 모달창
                    {
                        Close();
                        return;
                    }

                }
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message, "경고", MessageBoxButtons.OK);
            }
           

            
        }

        public static bool ValidateIPv4(string ip)
        {
            IPAddress address;
            return ip != null && ip.Count(c => c == '.') == 3 &&
                IPAddress.TryParse(ip, out address);
        }

    }
}
