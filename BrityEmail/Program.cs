using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Security.Permissions;
using System.Text;

namespace BrityEmail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string systemId = " "; // 시스템 아이디를 설정합니다.
            string accessToken = " "; // 접근 토큰을 설정합니다.
            string userId = "yurim.choi@britymail.com"; // 사용자 아이디를 설정합니다.
            string url = $"https://openapi.britymail.com/mail/api/v2.0/mails/send?userId={userId}";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            string boundary = "----WebKitFormBoundary7MA4YWxkTrZu0gW";
            request.ContentType = "multipart/form-data; boundary=" + boundary;
            request.Headers["Authorization"] = "Bearer " + accessToken;
            request.Headers["System-ID"] = systemId;

            Mail mailData = new Mail
            {
                subject = "EMAIL SUBJECT (이메일 제목)",
                contents = "EMAIL BODY (이메일 본문)",
                contentType = "TEXT",
                docSecuType = "PERSONAL",
                sender = new Sender { emailAddress = "yurim.choi@britymail.com" },
                recipients = new[]
                {
                new Recipient
                {
                    emailAddress = "yurim.choi@bizentro.com",
                    recipientType = "TO"
                }
            }
            };

            string mailJson = JsonConvert.SerializeObject(mailData);

            //body
            string formData = $"--{boundary}\r\n" +
                              "Content-Disposition: form-data; name=\"mail\"\r\n\r\n" +
                              mailJson + "\r\n" +
                              $"--{boundary}" ;

            byte[] byteArray = Encoding.UTF8.GetBytes(formData);

            request.ContentLength = byteArray.Length;

            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            string responseText = reader.ReadToEnd();
                            ResponseParameter responseData = JsonConvert.DeserializeObject<ResponseParameter>(responseText);
                            Console.WriteLine("Result: " + responseData.result);
                            Console.WriteLine("Mail ID: " + responseData.mailId);
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    using (WebResponse response = ex.Response)
                    {
                        HttpWebResponse httpResponse = (HttpWebResponse)response;
                        Console.WriteLine("Error code: " + httpResponse.StatusCode);
                        using (Stream data = response.GetResponseStream())
                        using (var reader = new StreamReader(data))
                        {
                            string text = reader.ReadToEnd();
                            Console.WriteLine(text);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("WebException: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }


        public class Sender
        {
            public string emailAddress { get; set; }
        }

        public class Recipient
        {
            public string emailAddress { get; set; }
            public string recipientType { get; set; }
        }

        public class Mail
        {
            public string subject { get; set; }
            public string contents { get; set; }
            public string contentType { get; set; }
            public string docSecuType { get; set; }
            public Sender sender { get; set; }
            public Recipient[] recipients { get; set; }
        }

        public class ResponseParameter
        {
            public string mailId { get; set; }
            public string result { get; set; }
        }
    }
 
}
