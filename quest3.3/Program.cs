using System;
using System.Text;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person()
    {
        Name = "idk";
        Age = 0;
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Family
{
    private Person[] members;
    private int memberCount;

    public Family(int size)
    {
        members = new Person[size];
        memberCount = 0;
    }

    public void AddMember(Person member)
    {
        if (memberCount < members.Length)
        {
            members[memberCount] = member;
            memberCount++;
        }
        else
        {
            Console.WriteLine("Масив членів родини переповнений!");
        }
    }

    public Person GetOldest()
    {
        if (memberCount == 0)
        {
            Console.WriteLine("Сім'я порожня.");
            return null;
        }

        Person oldest = members[0];
        for (int i = 1; i < memberCount; i++)
        {
            if (members[i].Age > oldest.Age)
            {
                oldest = members[i];
            }
        }
        return oldest;
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("Скільки людей ви хочете додати?");
        int numberOfPeople = int.Parse(Console.ReadLine());

        Family family = new Family(numberOfPeople);

        for (int i = 0; i < numberOfPeople; i++)
        {
            Console.WriteLine($"Введіть ім'я для людини №{i + 1}: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Введіть вік для людини №{i + 1}: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age < 0) 
            {
                Console.WriteLine("Будь ласка, введіть коректний вік:");
            }

            family.AddMember(new Person(name, age));
        }

        Person oldest = family.GetOldest();
        if (oldest != null)
        {
            Console.WriteLine($"Найстарший член родини: {oldest.Name} {oldest.Age}");
        }
    }
}
