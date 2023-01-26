using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static List<int> GetAllPrimary(int n)
        {
            List<int> list = new List<int>();
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    list.Add(i);
                }
            }
            return list;
        }

        public static bool IsDivisible(int a, int b)
        {
            return a % b == 0 ? true : false;
        }

        public static bool IsEven(int a)
        {
            return a % 2 == 0 ? true : false;
        }

        public static bool IsMajeur(int age)
        {
            return age < 18 ? false : true;
        }

        public static bool IsPrimary(int n)
        {
            int a = 0;
            for (int i = 1; i <= (n / 2) + n % 2; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            return a == 2 ? true : false;
        }

        public static int Power2(int a)
        {
            return (int)Math.Pow(a, 2);
        }

        public static int Power(int a, int b)
        {
            return (int)Math.Pow(a,b);
        }
    }
}
