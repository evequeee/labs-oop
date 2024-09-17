using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("Введіть рандомні символи для першого масиву через пробіл:");
        char[] firstltrarray = Console.ReadLine().Replace(" ", "").ToCharArray();

        Console.WriteLine("Введіть рандомні символи для другого масиву через пробіл: ");
        char[] secondltrarray = Console.ReadLine().Replace(" ", "").ToCharArray();

        int minLength = Math.Min(firstltrarray.Length, secondltrarray.Length); //Знаходимо мінімальну довжину з двох масивів//
        
        for (int i = 0; i < minLength; i++)
        {
            if (firstltrarray[i] < secondltrarray[i])
            {
                Console.WriteLine(new String(firstltrarray));
                Console.WriteLine(new String(secondltrarray));
                return;
            }
            else if (firstltrarray[i] > secondltrarray[i])
            {
                Console.WriteLine(new string(secondltrarray));
                Console.WriteLine(new string(firstltrarray));
                return;
            }
        }

        if (firstltrarray.Length < secondltrarray.Length)
        {
            Console.WriteLine(new string(firstltrarray));
            Console.WriteLine(new string(secondltrarray));
        }
        else if (firstltrarray.Length > secondltrarray.Length)
        {
            Console.WriteLine(new string(secondltrarray));
            Console.WriteLine(new string(firstltrarray));
        }
        else
        {
            Console.WriteLine(new string(firstltrarray));
        }
    }
}