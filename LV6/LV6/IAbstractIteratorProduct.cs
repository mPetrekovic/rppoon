﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6
{
    interface IAbstractIteratorProduct
    {
        Product First();
        Product Next();
        bool IsDone 
        {
            get; 
        }
        Product Current
        {
            get; 
        }
    }
}
