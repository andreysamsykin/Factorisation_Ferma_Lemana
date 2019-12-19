using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorisation_Ferma_Lemana
{
    class MyMath
    {
        /// <summary>
        /// Возвращает true, если a  является полным квадратом и false в противном случае
        /// </summary>
        /// <param name="a">Число, проверяемое на квадратность</param>
        /// <returns></returns>
        public static bool isSquare(ulong a) {
            if (Math.Sqrt(a)%1==0)
            {
                return true;
            }
            else return false;
        }


        /// <summary>
        /// Поиск НОД
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <returns>Наибольший общий делитель</returns>
        public static ulong GCD(ulong a, ulong b)
        {
            if (b == 0)
                return a;
            else
                return GCD(b, a % b);
        }

        /// <summary>
        /// Проверка числа на простоту
        /// </summary>
        /// <param name="n">Проверяемое число</param>
        /// <returns>Если число простое, возвращает true, иначе - false</returns>
        public static bool isPrime(ulong n)
        {
            for (ulong i = 2; i < n / 2 + 1; i++)
            {
                if ((n % i) == 0) return false;
            }
            return true;
        }

        public static bool isIntegerDivisionable(ulong a, ulong b)
        {
            if (a%b==0)
            {
                return true;
            }

            else return false;
        }
    }
}
