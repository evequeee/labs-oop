using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_01_in
{
    public interface ToCall
    {
        void Call(string number);
    }

    public interface Browser
    {
        void Browse(string url);
    }

    public class Smartphone : ToCall, Browser
    {
        public void Call(string number)
        {
            bool isAllDigits = true;
            foreach (char y in number)
            {
                if (!char.IsDigit(y))
                {
                    isAllDigits = false;
                    break;
                }
            }
            if (number.All(char.IsDigit))
            {
                Console.WriteLine($"Calling... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }

        public void Browse(string url)
        {
            bool nodigit = true;
            foreach (char y in url)
            {
                if (char.IsDigit(y))
                {
                    nodigit = false;
                    break;
                }
            }
            if (nodigit) Console.WriteLine($"Browsing: {url}");

            else Console.WriteLine("Invalid URL");

        }
    }
}