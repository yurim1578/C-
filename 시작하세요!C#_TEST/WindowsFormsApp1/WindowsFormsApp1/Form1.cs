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
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string loginName = textBox5.Text;
            string password = textBox6.Text;

            if (loginName == "admin" && password == "1234")
            {
                MessageBox.Show("Login Success", "Success");
            }
            else
            {
                MessageBox.Show("Access Denied", "Failure");
            }

        }

      
    }
}
