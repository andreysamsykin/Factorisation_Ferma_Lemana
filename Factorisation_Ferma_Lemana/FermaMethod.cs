using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorisation_Ferma_Lemana
{
    class FermaMethod
    {
        /// <summary>
        /// Факторизуемое число
        /// </summary>
        private static ulong n;

        /// <summary>
        /// Корень из факторизуемого числа
        /// </summary>
        private static ulong S;


        private static ulong y;
        /// <summary>
        /// Первое простое число
        /// </summary>
        private static ulong P;

        /// <summary>
        /// Второе простое число
        /// </summary>
        private static ulong J;

        /// <summary>
        ///Метод факторизации Ферма 
        /// </summary>
        /// <param name="n">Факторизуемое число</param>
        /// <returns></returns>

        public static ulong[] res = {0,0};
        public static string Ferma_Factorisation(ulong n)
        {
            S = Convert.ToUInt64(Math.Sqrt(n));

            for (ulong k = 0; k < S/2; k++)
            {
                y = Convert.ToUInt64(Math.Pow((S + k), 2)) - n;
                J = (S + k) - Convert.ToUInt64(Math.Sqrt(y));
                P = (S + k) + Convert.ToUInt64(Math.Sqrt(y));
                if (J*P == n)
                {
                    res[0] = J;
                    res[1] = P;
                    return $"Факторизация методом Ферма успешна. Числа: {res[0]}, {res[1]}. Количество шагов: {k}";
                }

            }
            return "Факторизация не удалась. Ошибка.";
        }
    }
}
