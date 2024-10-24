using EventHandlerTest1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private ConsoleMenu Menu;

        public Form1()
        {
            Menu = new ConsoleMenu();

            InitializeComponent();
        }
        
        private void Run()
        {
            Createmenu();

            while (true)
            {
                Menu.Show();
                Menu.Read();
            }
        }

        private void Createmenu()
        {
            EventHandlerTest1.MenuItem item = new EventHandlerTest1.MenuItem("1", "메뉴1", Menu_1_Callback);
            EventHandlerTest1.MenuItem item2 = new EventHandlerTest1.MenuItem("2", "메뉴2", Menu_2_Callback);
            EventHandlerTest1.MenuItem item3 = new EventHandlerTest1.MenuItem("q", "quit", Menu_q_Callback);

            Menu.MenuList.Add(item);
        }

        private void Menu_1_Callback(object sender, MenuArgs args)
        {
            Console.WriteLine($"menu1 callback() 호출 sender={sender.ToString()}, args={((MenuKeyPressArgs)args).Name}");
        }
        private void Menu_2_Callback(object sender, MenuArgs args)
        {
            Console.WriteLine($"menu2 callback() 호출 sender={sender.ToString()}, args={((MenuKeyPressArgs)args).Name}");
        }
        private void Menu_q_Callback(object sender, MenuArgs args)
        {
            Environment.Exit(0);
            Console.WriteLine($"menuq callback() 호출 sender={sender.ToString()}, args={((MenuKeyPressArgs)args).Name}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Run();
        }
    }
}
