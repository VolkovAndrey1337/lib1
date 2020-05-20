using System;

namespace Liba1
{
    public class lib1
    {
        static public string stpw(string a, int b)
        {
            string a1 = a;
            for (int i = 0; i < b - 1; i++)
            {
                a = a + a1;
            }
            return (a);
        }
        static public string revers(string a)
        {
            string h = "";
            for (int i = a.Length - 1; i > -1; i--)
            {
                h = h + a[i] + "";
            }
            return (h);
        }
        static public string remove(string str, string s)
        {
            for (int i = 0; i < str.Length; i++)
            {
                str = str.Replace(s, "");
            }
            return (str);
        }
        static public int length(string str)
        {
            int a = str.Length;
            return (a);
        }
    }
}