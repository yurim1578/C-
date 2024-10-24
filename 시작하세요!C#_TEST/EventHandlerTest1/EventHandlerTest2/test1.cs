using EventHandlerTest1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerTest2
{
    class test1
    {
        public static void Main(string[] args)
        {
            
        }

        ConsoleMenu Menu;

        

        public test1()
        {
            Menu = new ConsoleMenu();
           
        }

        private void Run()
        {

            Ceatemenu();
            while (true)
            {
                Menu.Show();
                Menu.Read();
            }

        }

        void Ceatemenu()
        {

            MenuItem item = new MenuItem("1", "메뉴1", Menu_1_Callback);
            item = new MenuItem("2", "메뉴2", Menu_2_Callback);
            item = new MenuItem("q", "quit", Menu_q_Callback);
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
    }
}
