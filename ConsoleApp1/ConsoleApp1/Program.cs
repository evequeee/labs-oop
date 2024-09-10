using System;
using System.Text;

class Program
{

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("Виберіть завдання, ввівши його номер від 4 до 17");

        string input = Console.ReadLine();
        int choice;
        if (int.TryParse(input, out choice))
        {
            switch (choice)
            {
                case 4: Console.WriteLine("Завдання 4");
                    Console.WriteLine("My favorite color is Purple");
                    break;
                case 5: Console.WriteLine("Завдання 5");
                    int a5;
                    int b5;
                    int c5;
                    int d5;
                    int e5;
                    int f5;


                    a5 = -128;
                    b5 = 128;
                    c5 = -3540;
                    d5 = 64876;
                    e5 = 214783648;
                    f5 = -1141583228;

                    Console.WriteLine("Значення першої змінної " + a5);
                    Console.WriteLine("Значення другої змінної " + b5);
                    Console.WriteLine("Значення третьої змінної " + c5);
                    Console.WriteLine("Значення четвертої змінної " + d5);
                    Console.WriteLine("Значення п'ятої змінної " + e5);
                    Console.WriteLine("Значення шостої змінної " + f5);
                    break;
                case 6: Console.WriteLine("Завдання 6");
                    decimal a6 = 3.141592653589793238m;
                    double b6 = 1.60217657;
                    decimal c6 = 7.8184261974584555216535342341m;

                    Console.WriteLine($"Перше значення: {a6}, Друге значення: {b6}, Третє значення: {c6}");
                    break;
                case 7: Console.WriteLine("Завдання 7");
                    string a7 = "Chernivtsi National University";
                    char b7 = 'B';
                    char c7 = 'y';
                    char d7 = 'e';
                    string e7 = "I love programming";
                    break;
                case 8: Console.WriteLine("Завдання 8");
                    int a8, b8, c8;
                    double avarage;

                    a8 = int.Parse(Console.ReadLine());
                    b8 = int.Parse(Console.ReadLine());
                    c8 = int.Parse(Console.ReadLine());

                    avarage = (a8 + b8 + c8) / 3;

                    Console.WriteLine(avarage);
                    break;
                case 9: Console.WriteLine("Завдання 9");
                    float a9, b9, h9, area9;


                    a9 = float.Parse(Console.ReadLine());
                    b9 = float.Parse(Console.ReadLine());
                    h9 = float.Parse(Console.ReadLine());
                    area9 = ((a9 + b9) / 2) * h9;

                    Console.WriteLine(area9);
                    break;
                case 10: Console.WriteLine("Завдання 10");
                    int n10, lastDigit10;
                    n10 = int.Parse(Console.ReadLine());
                    lastDigit10 = n10 % 10;

                    Console.WriteLine(lastDigit10);
                    break;
                case 11: Console.WriteLine("Завдання 11");
                    int number11, n11, ndigit11;
                    number11 = int.Parse(Console.ReadLine());
                    n11 = int.Parse(Console.ReadLine());
                    if (n11 > number11.ToString().Length)
                    {
                        Console.WriteLine("-");
                    }
                    else
                    {
                        ndigit11 = (number11 / (int)Math.Pow(10, n11 - 1)) % 10;
                        Console.WriteLine(ndigit11);
                    }
                    break;
                case 12: Console.WriteLine("Завдання 12");
                    int n12;
                    bool result12;

                    n12 = int.Parse(Console.ReadLine());

                    if (n12 > 20 && n12 % 10 == 1)
                    {
                        result12 = true;
                    }
                    else
                    {
                        result12 = false;
                    }
                    Console.WriteLine(result12);
                    break;
                case 13: Console.WriteLine("Завдання 13");
                    int n13;
                    bool result13;

                    n13 = int.Parse(Console.ReadLine());

                    result13 = (n13 % 9 == 0) || (n13 % 11 == 0) || (n13 % 13 == 0);

                    Console.WriteLine(result13);
                    break;
                case 14: Console.WriteLine("Завдання 14");
                    int a14, b14, c14;
                    a14 = int.Parse(Console.ReadLine());
                    b14 = int.Parse(Console.ReadLine());
                    c14 = int.Parse(Console.ReadLine());
                    int max = a14;
                    if (b14 > max)
                    {
                        max = b14;
                    }
                    if (c14 > max)
                    {
                        max = c14;
                    }
                    Console.WriteLine("Найбільше число: " + max);
                    break;
                case 15: Console.WriteLine("Завдання 15");
                    double a15, b15, c15, product15;
                    a15 = int.Parse(Console.ReadLine());
                    b15 = int.Parse(Console.ReadLine());
                    c15 = int.Parse(Console.ReadLine());
                    int negativeCount15 = 0;
                    if (a15 < 0)
                    {
                        negativeCount15++;
                    }
                    if (b15 < 0)
                    {
                        negativeCount15++;
                    }
                    if (c15 < 0)
                    {
                        negativeCount15++;
                    }
                    if (negativeCount15 == 1 || negativeCount15 == 3)
                    {
                        Console.WriteLine("Знак негативний.");
                    }
                    else if (negativeCount15 == 0 || negativeCount15 == 2)
                    {
                        Console.WriteLine("Знак позитивний.");
                    }
                    break;
                case 16: Console.WriteLine("Завдання 16");
                    Console.WriteLine("Choose your day from 1 to 7");
                    int n16;
                    n16 = int.Parse(Console.ReadLine());
                    switch (n16)
                    {
                        case 1:
                            Console.WriteLine("Monday");
                            break;
                        case 2:
                            Console.WriteLine("Tuesday");
                            break;
                        case 3:
                            Console.WriteLine("Wednesday");
                            break;
                        case 4:
                            Console.WriteLine("Thursday");
                            break;
                        case 5:
                            Console.WriteLine("Friday");
                            break;
                        case 6:
                            Console.WriteLine("Saturday");
                            break;
                        case 7:
                            Console.WriteLine("Sunday");
                            break;
                        default:
                            Console.WriteLine("не дійсний");
                            break;
                    }
                    break;
                case 17: Console.WriteLine("Завдання 17");
                    int n17, factorial17;
                    factorial17 = 1;
                    n17 = int.Parse(Console.ReadLine());
                    for (int i17 = 2; i17 <= n17; i17++)
                    {
                        factorial17 = factorial17 * i17;
                    }
                    Console.WriteLine("Факторіал числа: " + factorial17);
                    break;
                default: Console.WriteLine("Введіть коректний номер завдання");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Введіть коректний номер завдання");
        }
            
    }
}