using System;
using System.Collections.Generic;

class Person
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0)
            {
                age = value;
            }
            else
            {
                Console.WriteLine("Вік не може бути від'ємним");
            }
        }
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void info()
    {
        Console.WriteLine($"Ім'я: {Name}, Вік: {Age}");
    }
}

class Program
{
    static void Main()
    {
        List<Person> persons = new List<Person>();

        Console.WriteLine("Введіть бажану кількість осіб");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Введіть ім'я для особи №{i + 1}:");
            string name = Console.ReadLine();

            Console.WriteLine($"Введіть вік для особи №{i + 1}:");
            int age;

            while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
            {
                Console.WriteLine("Будь ласка, введіть коректний вік:");
            }

            persons.Add(new Person(name, age));
        }

        Console.WriteLine("\nСписок створених осіб:");
        foreach (var person in persons)
        {
            person.info();
        }
    }
}
