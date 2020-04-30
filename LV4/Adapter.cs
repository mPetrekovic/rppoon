using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4
{
    class Adapter : IAnalytics
    {
        private Analyzer3rdParty analyticsService;
        public Adapter(Analyzer3rdParty service)
        {
            this.analyticsService = service;
        }
        private double[][] ConvertData(Dataset dataset)
        {
            int rows = dataset.GetData().Count;
            double[][] data = new double[rows][];
            for (int i = 0; i < rows; i++)
            {
                data[i] = new double[dataset.GetData()[i].Count];
                for (int j = 0; j < dataset.GetData()[i].Count; j++)
                {
                    data[i][j] = dataset.GetData()[i][j];
                }

            }
            return data;
        }
        public double[] CalculateAveragePerColumn(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerColumnAverage(data);
        }
        public double[] CalculateAveragePerRow(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerRowAverage(data);
        }
    }
}
