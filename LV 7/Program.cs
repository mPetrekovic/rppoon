using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Random rand = new Random();
            BubbleSort sortStrategy = new BubbleSort();
            NumberSequence array = new NumberSequence(n);
            for (int i = 0; i < n; i++) 
            {
                array.InsertAt(i, rand.NextDouble());
            }
            array.SetSortStrategy(sortStrategy);
            Console.WriteLine("nesortiran: " + array.ToString());
            array.Sort();
            Console.WriteLine("sortiran: " + array.ToString());
            Console.Read();
        }
    }
}
