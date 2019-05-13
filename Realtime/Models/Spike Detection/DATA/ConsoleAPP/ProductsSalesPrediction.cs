using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realtime_API.Models.Spike_Detection.DATA.ConsoleAPP
{   
    public class ProductsSalesPrediction
    {
    //vector to hold alert,score,p-value values
    //[VectorType(3)]
    public double[] Prediction { get; set; }
    }
}
