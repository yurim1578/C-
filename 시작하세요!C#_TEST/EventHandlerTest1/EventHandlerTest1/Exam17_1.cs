using System;
using System.Security.Cryptography;

namespace EventHandlerTest1
{
    class Exam17_1  
    {
        static public void Main(string[] args)
        {
            Run();
        }

        delegate void MyDelegate(int val);
        delegate int MyDelegate2(int val); 

        static public void Run() 
        {
            int a = 3;
            Console.WriteLine(a);

            Student st = new Student();
            st.name = "홍길동";
            Console.WriteLine(st);

            //Delegatetest(3);
            MyDelegate dele = new MyDelegate(Delegatetest);
            MyDelegate2 dele1 = new MyDelegate2(Delegatetest2);
            dele(4);
            Console.WriteLine(dele1(5));
        }

        
        static private void Delegatetest(int myVal)
        {
            Console.WriteLine($"DelegeteTest() called {myVal}");
        }

       static private int Delegatetest2(int myVal)
        {
            return myVal + 1;
        }
    }
}
