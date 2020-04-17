using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2
{
        class Program
    {
        static void Main(string[] args)
        {
            // Prvi zadatak
            DiceRoller poolOfDice = new DiceRoller();
            for (int i=0; i < 20; i++) 
            {
                Die die = new Die(6);
                poolOfDice.InsertDie(die);
            }
            poolOfDice.RollAllDice();

            foreach (int result in poolOfDice.GetRollingResults())
            {
                Console.WriteLine("rezultat:" + (0), result);
            }
            //Drugi zadatak
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                Die die = new Die(6,random);
                poolOfDice.InsertDie(die);
            }
            poolOfDice.RollAllDice();

            foreach (int result in poolOfDice.GetRollingResults())
            {
                Console.WriteLine("rezultat:" + (0), result);
            }
            Console.Read();
        }
    }
}
