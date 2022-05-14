using System;
using TestLibrary;

namespace GithubAppLab03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = { "asdf", "qwer", "" };
            a[2] = Mathematics.Add<string>(a[0], a[1]);

            float[] s = { 12f, 11.9999f, 0 };
            s[2] = Mathematics.Multiply<float>(s[0], s[1]);

            double[] m = { 3.141592, 3.141592, 0 };
            m[2] = Mathematics.Multiply<double>(m[0], m[1]);

            int[] d = { 16, 3, 0 };
            d[2] = Mathematics.Divide<int>(d[0], d[1]);

            var e = Mathematics.Add<char>('a', 'b');

            Console.WriteLine($"{a[2]}  {s[2]}  {m[2]}  {d[2]}  {e == default}");
            System.Threading.Thread.Sleep(4000);
        }
    }
}
