using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV_7
{
    class LinearSearch : SearchStrategy
    {
        public override double Search(double[] array, double target)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == target)
                    return i;
            }
            return -1;
        }
    }
}
