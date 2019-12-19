using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorisation_Ferma_Lemana
{
    class Program
    {
        static double pow = 1 / 3;
        static void Main(string[] args)
        {
            LemanaMethod.LemanaFactorisation(168829);
            //Console.WriteLine(Math.Pow(216,1/3f));
        }
    }
}
