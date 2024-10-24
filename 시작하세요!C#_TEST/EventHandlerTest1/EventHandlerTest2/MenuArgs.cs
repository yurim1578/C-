namespace EventHandlerTest1
{



    internal class MenuArgs
    {

    }
    class MenuKeyPressArgs : MenuArgs
    {
        public string Name { get; set; }

        public MenuKeyPressArgs(string name)
        {
            Name = name;
        }
    }
}