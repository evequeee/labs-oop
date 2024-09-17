using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("Введіть число n: ");
        int n = int.Parse(Console.ReadLine());

        bool[] oprime = new bool[n + 1];
        for (int i = 2; i <= n; i++)
        {
            oprime[i] = true;
        }

        for (int p = 2; p * p <= n; p++)
        {
            if (oprime[p])
            {
                for (int i = p * p; i <= n; i += p)
                {
                    oprime[i] = false;
                }
            }
        }
        for (int i = 2; i <= n; i++)
        {
            if (oprime[i])
            {
                Console.WriteLine(i);
            }
        }
    }
}