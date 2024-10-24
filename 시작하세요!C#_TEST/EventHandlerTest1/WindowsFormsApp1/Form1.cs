using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

       static public void Main();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  //델리게이트가 들어있다.  //요소 중요하게 볼것
        {
            //사실은 델리게이트인이벤트발생
            textBox1.Text = "버튼이 눌러졌다";
        }
    }
}
