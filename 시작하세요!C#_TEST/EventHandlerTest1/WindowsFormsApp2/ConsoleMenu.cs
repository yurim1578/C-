using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerTest1
{
    class ConsoleMenu
    {
        public List<MenuItem> MenuList { get; set; }
        public ConsoleMenu()
        {
            MenuList=new List<MenuItem>();
        }

        public void Show()
        {
            foreach (MenuItem item in MenuList)
            {
                Console.WriteLine($"{item._Name},{item._Value}");
            }
            Console.WriteLine();
        }

        public void Read()
        {
            Console.WriteLine("메뉴선택");
            string retVal = Console.ReadLine();

            foreach(MenuItem item in MenuList)
            {
                if (item._Name == retVal && item._keyPressDelegate != null) //null체크 중요
                {
                    item._keyPressDelegate(this, new MenuKeyPressArgs(retVal));//delegate호출
                }
            }
        }
    }
}
