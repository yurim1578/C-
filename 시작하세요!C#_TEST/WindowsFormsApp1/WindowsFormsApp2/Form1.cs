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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //모든 요소들을 초기화
            this.Load += Form1_Load;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string[] data = { "1학년", "2학년", "3학년", "4학년", "5학년", "6학년"};

            //데이터 초기화
            comboBox1.Items.AddRange(data);

            comboBox1.SelectedIndex = 0;

            string[] data2= { "2500$", "3000$", "3500$" };
            comboBox2.Items.AddRange(data2);
            comboBox2.SelectedIndex = 0;
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string name = textBox2.Text;

            string grade = "";
            if (comboBox1.SelectedIndex >= 0)
            {
                grade = comboBox1.SelectedItem.ToString();

            }

            string date=dateTimePicker1.Value.ToString();

            string amount = "";
            if(comboBox2.SelectedIndex >= 0)
            {
                amount= comboBox2.SelectedItem.ToString();
            }

            string data = id + ", " + name + ", " + grade + ", " + date + ", " + amount;

            StreamWriter wr = new StreamWriter("data.txt",true);    //기본경로에 이름.확장명 으로 데이터를 쌓아서 저장하겠다.
            wr.WriteLine(data);
            wr.Close();

            int value1 = 1;
            int value2 = 2;

            int a = value2;

            value2 = value1;
            value1 = a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Today;
        }

        private void button3_Click(object sender, EventArgs e)
        {
          

            Form3 form3 = new Form3("data.txt");
            form3.ShowDialog();
            
        }
    }
}
