﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtime_Pharmaceutical.SpikeDetection.DATA.ConsoleAPP
{
    public class ProductSalesPrediction
    {
        //vector to hold alert,score,p-value values
        //[VectorType(3)]
        public double[] Prediction { get; set; }
    }
}
