﻿using Bizentro.AppFramework.UI.Controls;
using Bizentro.AppFramework.UI.Variables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OZreport_frmtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 300;
            this.Height = 100;

            AutoScroll = false;
            MinimizeBox = true;
            FormBorderStyle = FormBorderStyle.Sizable;
            Dock = DockStyle.Fill;
            StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
