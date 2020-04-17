using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2
{
    //Treči zadatak
    class Die2
    {
        private int numberOfSides;
        private RandomGenerator randomGenerator;

        public Die2(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = new RandomGenerator();
        }
        public int Roll()
        {
            int rolledNumber = randomGenerator.NextInt(1, numberOfSides);
            return rolledNumber;
        }
    }
}
