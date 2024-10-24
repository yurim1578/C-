using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerTest1
{
    internal class MenuItem
    {

        public delegate void MenuKeyPressDelegate(object sender, MenuArgs args);
        public string _Name { get; set; }
        public string _Value { get; set; }

        public MenuKeyPressDelegate _keyPressDelegate { get; set; }  //func(sender, args)

        public MenuItem(String Name, String Value, MenuKeyPressDelegate keydele) {

            _Name=Name;
            _Value=Value;
            _keyPressDelegate=keydele;
        }
        public MenuItem() : this(null, null,null)
        {}
    }
}