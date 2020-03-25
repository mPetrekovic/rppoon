using System;

namespace LV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Note prva = new Note();
            Note druga = new Note("Mr. Someone");
            Note treca = new Note("Ovo je druga biljeska", "Mr. SomeoneElse", 3);
            Console.WriteLine(prva.getText());
            Console.WriteLine(prva.getAuthor());
            Console.WriteLine(druga.getText());
            Console.WriteLine(druga.getAuthor());
            Console.WriteLine(treca.getText());
            Console.WriteLine(treca.getAuthor());

        }
    }
}
