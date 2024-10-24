using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Net.Http.Formatting;
using Microsoft.VisualBasic.ApplicationServices;

namespace mailAPI
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        public class ReturnData
        {
            public string Auth { get; set; }
            public bool IsError { get; set; }
            public string MessageCode { get; set; }
            public string MessageText { get; set; }
        }
        public class result
        {
            public UserInfo userinfo { get; set; }
        }
        public class UserInfo
        {
            public string ConnKey { get; set; }
            public string userID { get; set; }
            public string Company { get; set; }
            public string serviceKind { get; set; }
        }
            private void ultraButton1_Click(object sender, EventArgs e)
        {
            string url = "http://172.16.1.218/U2000_Default/Services/Common/PortalService.asmx/GetJsonTicket";
            //string userInfo = "{userinfo:{ ConnKey: \"unierp50n\", Company : \"U2000\", UserID : \"UNIERP\", serviceKind : \"U\" }}";

            UserInfo info=new UserInfo();
            info.ConnKey = "UNIERP50N";
            info.Company = "U2000";
            info.userID = "UNIERP";
            info.serviceKind = "U";
            result result = new result();
            result.userinfo = info;



            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json; charset=utf-8";
            request.Timeout = 30 * 1000;
            //request.Headers.Add("Authorization", "BASIC SGVsbG8=");
            string serializeJson = JsonConvert.SerializeObject(result);
            // POST할 데이타를 Request Stream에 쓴다
            byte[] bytes = Encoding.ASCII.GetBytes(serializeJson);
            request.ContentLength = bytes.Length; // 바이트수 지정

            using (Stream reqStream = request.GetRequestStream())
            {
                reqStream.Write(bytes, 0, bytes.Length);
            }

            // Response 처리
            string responseText = string.Empty;
            using (WebResponse resp = request.GetResponse())
            {
                Stream respStream = resp.GetResponseStream();
                using (StreamReader sr = new StreamReader(respStream))
                {
                    responseText = sr.ReadToEnd();
                  
                }
            }
            var desirialize = JsonConvert.DeserializeObject<Dictionary<string,object>>(responseText);
            var desirialize2 = desirialize["d"];

           var desirialize3 = JsonConvert.DeserializeObject<Dictionary<string, object>>(desirialize2.ToString());

           textBox1.Text = desirialize3["Auth"].ToString();
        }
    }
        
       
    
}
