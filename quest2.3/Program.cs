using System;

class Program
{
    static void Main()
    {
        int[] array = { 5, 2, 3, 6};
        FoldAndSum(array);
    }
    static void FoldAndSum(int[] array)
    {
        int k = array.Length / 4;
        int[] firstrow = array.Take(k).Reverse().Concat(array.Skip(k * 3).Take(k).Reverse()).ToArray();
        int[] secondrow = array.Skip(k).Take(2 * k).ToArray();
        //складаємо значення двох масивів і повертаємо підсумок//
        int[] result = firstrow.Zip(secondrow, (x, y) => x + y).ToArray(); //Zip - метод який з'єднує два масиви, бере перший елемент з firstRow і перший елемент з secondRow//

        Console.WriteLine(string.Join(" ", result));
    }
}