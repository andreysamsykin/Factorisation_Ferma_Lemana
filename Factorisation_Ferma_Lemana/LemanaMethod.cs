using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorisation_Ferma_Lemana
{
    class LemanaMethod
    {
        /// <summary>
        /// Факторизуемое число
        /// </summary>
        private static ulong n;

        /// <summary>
        /// Первое простое число
        /// </summary>
        private static ulong A;

        /// <summary>
        /// Второе простое число
        /// </summary>
        private static ulong B;

        public static void LemanaFactorisation(ulong n)
        {
            #region
            for (ulong a = 2; a < Math.Pow(n, 1 / 3f); a++)
            {
                if (MyMath.isIntegerDivisionable(a, n))
                {
                    Console.WriteLine($"33");

                }
            }
            for (ulong k = 1; k < Math.Pow(n, 1 / 3f); k++)
            {
                for (int d = 0; d < (Math.Pow(n, 1 / 6f) / 4 * Math.Sqrt(k)); d++)
                {
                    if (MyMath.isSquare(Convert.ToUInt64(Math.Pow((Math.Sqrt(4 * k * n) + d), 2) - 4 * k * n)))
                    {
                        A = Convert.ToUInt64(Math.Sqrt(4 * k * n) + d);
                        B = Convert.ToUInt64(Math.Sqrt(A * A - 4 * k * n));
                        if (1 < MyMath.GCD(A + B, n) && MyMath.GCD(A + B, n) < n)
                        {
                            Console.WriteLine($"{MyMath.GCD(A + B, n)}");
                        }
                        else if (1 < MyMath.GCD(A - B, n) && MyMath.GCD(A - B, n) < n)
                        {
                            Console.WriteLine($"{MyMath.GCD(A - B, n)}");
                        }
                    }
                }
            }
            #endregion


        }
    }
}
