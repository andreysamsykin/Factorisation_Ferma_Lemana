﻿using System;
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

        private static int steps = 0;
        private static int counter = 0;

        public static ulong[] res = new ulong[2];
        /// <summary>
        /// Факторизация методом Лемана
        /// </summary>
        /// <param name="n">Факторизуемое число</param>
        public static string LemanaFactorisation(ulong n)
        {
            for (ulong a = 2; a < Math.Pow(n, 1 / 3f); a++)
            {
                if (MyMath.isIntegerDivisionable(a, n))
                {
                    Console.WriteLine($"33");

                }
            }
            for (ulong k = 1; k < Math.Pow(n, 1 / 3f); k++)
            {
                for (int d = 0; d < (Math.Pow(n, 1 / 6f) / (4 * Math.Sqrt(k))) + 1; d++)
                {
                    if (MyMath.isSquare(Convert.ToUInt64(Math.Pow((Math.Sqrt(4 * k * n) + d), 2) - 4 * k * n)))
                    {
                        A = Convert.ToUInt64(Math.Sqrt(4 * k * n) + d);
                        B = Convert.ToUInt64(Math.Sqrt(A * A - 4 * k * n));
                        if (1 < MyMath.GCD(A - B, n) && MyMath.GCD(A - B, n) < n)
                        {   
                            res[0] = MyMath.GCD(A - B, n);
                            res[1] = n / res[0];
                        }
                    }
                    steps = d;
                }
            }

            if (res[0] != 0 && res[1] != 0)
            {
                return $"Факторизация методом Лемана успешна. Числа: {res[0]}, {res[1]}. Количество шагов: {steps}";
            }
            else
            {
                return "Факторизация не удалась. Ошибка.";
            }

        }
    }
}
