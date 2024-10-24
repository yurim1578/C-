// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string txt = "Hello";
string txt2 = "Hello";
Console.WriteLine(txt.Equals(txt2));//true
Console.WriteLine(txt.GetHashCode());
Console.WriteLine(txt.ToString().Equals(txt2.ToString()));//true
Console.WriteLine(txt2.GetHashCode()); //참조타입? -> value 비교


