using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsToVector
 
 
{
    class KNNProgram
    {
         
            static double Distance(double[] v1, double[] v2)
            {
                double sum = 0.0;
                for (int i = 0; i < v1.Length; ++i)
                    sum += (v1[i] - v2[i]) * (v1[i] - v2[i]);
                return Math.Sqrt(sum);
            }
        }
    }
