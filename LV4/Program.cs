using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset testExample = new Dataset("TestFile.txt");
            double[] rowsAvg, columnsAvg;
            Analyzer3rdParty matrixAnalyzer = new Analyzer3rdParty();
            Adapter list2DToMatrix = new Adapter(matrixAnalyzer);
            rowsAvg = list2DToMatrix.CalculateAveragePerRow(testExample);
            columnsAvg = list2DToMatrix.CalculateAveragePerColumn(testExample);
            for (int i = 0; i < columnsAvg.Length; i++) 
            {
                Console.WriteLine("average result in " + (i + 1) + ". column:" + columnsAvg[i]);
            }
            for (int i = 0; i < rowsAvg.Length; i++)
            {
                Console.WriteLine("average result in " + (i + 1) + ". row:" + rowsAvg[i]);
            }
            Console.ReadLine();
        }
    }
}
