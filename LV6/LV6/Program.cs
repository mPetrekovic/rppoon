using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook myNotebook = new Notebook();
            Note page1 = new Note("podsjetnik","nemoj zaboraviti postaviti link gitHuba na stranicu kolegija");
            Note page2 = new Note("zubar","imas zakazano kod zubara petak 20.5.2020");
            myNotebook.AddNote(page1);
            myNotebook.AddNote(page2);
            Console.WriteLine("broj stranica je: {0}",myNotebook.Count);
            myNotebook.RemoveNote(page2);
            Console.WriteLine("broj stranica je: {0}", myNotebook.Count);
            myNotebook.Clear();
            Console.WriteLine("broj stranica je: {0}", myNotebook.Count);
            Console.Read();

        }
    }
}
