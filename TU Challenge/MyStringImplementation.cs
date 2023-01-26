using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input == null) return true;

            foreach (char c in input)
            {
                if (c != ' ') return false;
            }
            return true;
        }

        public static string MixString(string a, string b)
        {
            if (a == string.Empty || b == string.Empty || a == null || b == null)
                throw new ArgumentException();

            string result = "";

            int minLength = Math.Min(a.Length, b.Length);
            for (int i = 0; i < minLength; i++)
            {
                result += a[i];
                result += b[i];
            }

            if (a.Length > minLength)
            {
                result += a.Substring(minLength);
            }
            else if (b.Length > minLength)
            {
                result += b.Substring(minLength);
            }

            return result;
        }

        public static string ToLowerCase(string a)
        {
            string r = "";
            foreach (char c in a)
            {
                if (c >= 65 && c <= 90 || c >= 182 && c <= 214)
                {
                    r += (char)(c + 32);
                }
                else
                {
                    r += (char)(c);
                }
            }
            return r;
        }

        public static string Voyelles(string a)
        {
            string result = "";
            List<int> listVoyelle = new List<int>() { 65, 69, 73, 79, 85, 89, 97, 101, 105, 111, 117, 121 };
            foreach (char c in a)
            {
                for (int i = 0; i < listVoyelle.Count(); i++)
                {
                    if ((int)c == listVoyelle[i])
                    {
                        result += c;
                        listVoyelle.Remove((int)c);
                    }
                }
            }
            return ToLowerCase(result);
        }

        public static string Reverse(string a)
        {
            string r = "";

            for (int i = a.Length - 1; i >= 0; i--)
            {
                r += a[i];
            }
            return r;
        }

        public static string BazardString(string input)
        {
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                result += input[i];
                i++;
            }
            for (int i = 1; i < input.Length; i++)
            {
                result += input[i];
                i++;
            }
            return result;
        }
        public static string UnBazardString(string input)
        {
            string result = "";
            for (int i = 0; i < input.Length / 2; i++)
            {
                result += input[i];
                result += input[i + input.Length / 2];
            }
            return result;
        }
    }
}
