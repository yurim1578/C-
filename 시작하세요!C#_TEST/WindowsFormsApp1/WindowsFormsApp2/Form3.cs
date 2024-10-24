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

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        //private string _v;    //보통 필드명에는 _(언더바)를 앞에 붙이고, this를 붙이지 않는다. 

        public Form3(string v)  //생성자 문제
        { 
            InitializeComponent();
            LoadData(v);
            //_v = v;
            //this.Load += Form3_Load;    //이벤트 발생!
        }

        private void LoadData(string v)
        {   //컬렉션리스트 
            List<Donation> donations = new List<Donation>();

            //Stream으로 데이타 읽기
            StreamReader rd = new StreamReader(v);

            while(!rd.EndOfStream)
            {
                string line = rd.ReadLine();
                string[] cols = line.Split(',');

                //컬럼들로 Donation 객체 만들기
                Donation donation = new Donation();
                donation.Id = cols[0];
                donation.Name = cols[1];
                donation.Grade = cols[2];
                donation.Date = DateTime.Parse(cols[3]);
                donation.Amount = cols[4];

                //donations에 donation 추가
                donations.Add(donation);
            }

            rd.Close(); //StreamReader 닫음

            //DataGridView 의 DataSource 속성에 Donation 리스트 (컬렉션) 지정하여 "데이터 바인딩 하기"
            dataGridView1.DataSource = donations;
        }

        class Donation      //객체,Dto 비스무리
        {
            //필드
            public String Id { get; set; }
            public string Name { get; set; }
            public string Grade { get; set; }
            public DateTime Date { get; set; }
            public string Amount { get; set; }
        }

        /*

        private void LoadData(string v) //메서드 만들어서 생성자에 넣어주는 방법!
        {
            dataGridView1.Columns.Add("id", "I");
            dataGridView1.Columns.Add("name", "N");
            dataGridView1.Columns.Add("grade", "G");
            dataGridView1.Columns.Add("date", "D");
            dataGridView1.Columns.Add("amount", "A");

            StreamReader rd = new StreamReader(v);

            while (!rd.EndOfStream)
            {
                string line = rd.ReadLine();
                string[] cols = line.Split(',');

                dataGridView1.Rows.Add(cols[0], cols[1], cols[2], cols[3], cols[4]);
            }

            rd.Close();
        }
        */
        /*
        private void Form3_Load(object sender, EventArgs e) 
        {

            dataGridView1.Columns.Add("id", "I");
            dataGridView1.Columns.Add("name", "N");
            dataGridView1.Columns.Add("grade", "G");
            dataGridView1.Columns.Add("date", "D");
            dataGridView1.Columns.Add("amount", "A");

            StreamReader rd = new StreamReader(v);

            while (!rd.EndOfStream)
            {
                string line = rd.ReadLine();
                string[] cols = line.Split(',');

                dataGridView1.Rows.Add(cols[0], cols[1], cols[2], cols[3], cols[4]);
            }

            rd.Close();
        }
        */
    }
}
