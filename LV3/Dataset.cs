﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV3
{
    interface Prototype
    {
        Prototype Clone();
    }
    class Dataset : Prototype
    {
        private List<List<string>> data; //list of lists of strings 
        public Dataset()
        {
            this.data = new List<List<string>>();
        }
        public Dataset(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }
        public void LoadDataFromCSV(string filePath)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach (string item in items)
                    {
                        row.Add(item);
                    }
                    this.data.Add(row);
                }
            }
        }
        public IList<List<string>> GetData()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
        }
        public void ClearData() 
        {
            this.data.Clear();
        }
        public Prototype Clone()
        {
            private Dataset copy = new Dataset();
            string line;
            foreach(List<string> line in this.data)
            {
                List<string> row = new List<string>();
                string items = line;
                foreach (string item in items)
                {
                    row.Add(item); 
                }
                this.data.Add(row); 
            }
            return (Prototype)copy;
        }
    }
}