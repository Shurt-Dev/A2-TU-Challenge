using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization.Formatters;
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
            for (int i = 2; i <= n; i++)
            {
                if (IsPrimary(i))
                {
                    list.Add(i);
                };
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
            if (age > 145 || age < 0)
            {
                throw new ArgumentException();
            }
            return age < 18 ? false : true;
        }

        public static bool IsPrimary(int n)
        {
            int a = 1;
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
            return a * a;
        }

        public static int Power(int a, int b)
        {
            return (int)Math.Pow(a, b);
        }

        public static int IsInOrder(int a, int b)
        {
            if (a == b)
                return 0;
            return (b - a) / Math.Abs(b - a);
        }

        public static List<int> Sort(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[i] < list[j] && i > j)
                    {

                        int temp = list[i];
                        for (int k = i; k > j; k--)
                        {
                            list[k] = list[k - 1];
                        }
                        list[j] = temp;
                    }
                }
            }
            /*for (int i = 0; i < list.Count; i++)
            {
                for (int j = i+i; j < list.Count; j++)
                {
                    if (list[j] < list[i])
                    {
                        int temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }*/
            return list;
        }

        public static bool IsListInOrder(List<int> list)
        {
            if (list.Count < 2)
                return true;
            for (int i = 0; i < list.Count - 1; i++)
            {
                int result = IsInOrder(list[i], list[i + 1]);
                if (result < 0)
                    return false;
            }
            return true;
        }
    }
}
