using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV3
{
    class RandomMatrix
    {
        private static RandomMatrix instance;
        private Random[][] generator;
        private RandomMatrix(int a,int b)
        {
            for (int i = 0; i < a; i++) 
                for (int j = 0; j < b; j++) 
            this.generator[i][j] = new Random(1); 
        }
        public static RandomMatrix GetInstance()
        {
            if (instance == null)
            {
                instance = new RandomMatrix(1,1);            
            }
            return instance; 
        }
        public double[][] zadatakDva(int a,int b)  
        {
            private double matrica[a][b] = new double;
            for (int i = 0; i<a; i++) 
                for (int j = 0; j<b; j++) 
                    matrica[i][j]=Random a.Next(1);
            return matrica;
        }
    }
}
