using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("Введіть числа для масиву: ");
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Console.WriteLine("Введіть кількість обертів k: ");
        int k = int.Parse(Console.ReadLine());

        int[] summary = new int[array.Length];

        for (int rott = 0; rott < k; rott++)
        {
            array = RotateRight(array);

            for (int i = 0; i < array.Length; i++)
            {
                summary[i] += array[i];
            }
        }
        Console.WriteLine("Summary: " + string.Join(" ", summary));
    }

    static int[] RotateRight(int[] array)
    {
        int[] rotted = new int[array.Length];
        rotted[0] = array[array.Length - 1];

        for (int i = 1; i < array.Length; i++)
        {
            rotted[i] = array[i - 1];
        }

        Console.WriteLine("Rotate: " + string.Join(" ", rotted));

        return rotted;
    }
}