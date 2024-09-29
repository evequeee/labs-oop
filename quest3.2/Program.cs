using System;
using System.Text;

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

    public Person() : this("No name", 1)
    {
    }

    public Person(int age) : this("No name", age)
    {
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
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Person person1 = new Person();
        person1.info();

        Person person2 = new Person(48);
        person2.info();

        Person person3 = new Person("Райден", 32);
        person3.info();
    }
}
