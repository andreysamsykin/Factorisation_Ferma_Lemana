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
            Console.WriteLine("Введите число, которое хотите факторизовать: ");
            ulong numb = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine(FermaMethod.Ferma_Factorisation(numb));
            Console.WriteLine(LemanaMethod.LemanaFactorisation(numb));
        }
    }
}