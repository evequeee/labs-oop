using System;
using System.Text;

namespace quest7_1
{
    using Task7_01_in;

    class Program
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();

            Smartphone smartphone = new Smartphone();

            foreach (var number in numbers) smartphone.Call(number);


            foreach (var url in urls) smartphone.Browse(url);
        }
    }
}