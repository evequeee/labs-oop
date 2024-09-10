using System;
using System.Text;

class Program
{

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        string[] firstarea = Console.ReadLine().Split(' ');
        string[] secondarea = Console.ReadLine().Split(' ');

          int leftMatch = FindCommonLeftEnd(firstarea, secondarea);

           int rightMatch = FindCommonRightEnd(firstarea, secondarea);

                    if (leftMatch > rightMatch && leftMatch > 0)
                    {
                        Console.WriteLine($"Найбільний спільний кінець зліва - {leftMatch}");
                    }
                    else if (rightMatch > leftMatch && rightMatch > 0)
                    {
                        Console.WriteLine($"Найбільний спільний кінець зправа - {rightMatch}");
                    }
                    else
                    {
                        Console.WriteLine("Ні з одної з сторін немає спільних слів");
                    }

                    static int FindCommonLeftEnd(string[] firstarea, string[] secondarea)
                    {
                        int minLenght = Math.Min(firstarea.Length, secondarea.Length);
                        int count = 0;

                        for (int i = 0; i < minLenght; i++)
                        {
                            if (firstarea[i] == secondarea[i])
                            {
                                count++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        return count;
                    }
                    static int FindCommonRightEnd(string[] firstarea, string[] secondarea)
                    {
                        int minLength = Math.Min(firstarea.Length, secondarea.Length);
                        int count = 0;

                        for (int i = 0; i < minLength; i++)
                        {
                            if (firstarea[firstarea.Length - 1 - i] == secondarea[secondarea.Length - 1 - i])
                            {
                                count++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        return count;
                    }

    }
}
