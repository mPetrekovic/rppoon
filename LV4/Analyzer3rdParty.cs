using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4
{
    class Analyzer3rdParty
    {
        public double[] PerRowAverage(double[][] data)
        {
            int rowCount = data.Length;
            double[] results = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                results[i] = data[i].Average();
            }
            return results;
        }
        public double[] PerColumnAverage(double[][] data)
        {
            int columnCount = data[0].Length;
            double[] results = new double[columnCount];
            int j;
            for (int i = 0; i < data.Length; i++)
            {
                for (j = 0; j < columnCount; j++)
                {
                    results[i] += data[i][j];
                }
                results[i] /= (j+1);
            }
            return results;
        }
    }
}