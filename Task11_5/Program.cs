using System;
using System.Linq;

namespace InfernoIII
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                switch (command)
                {
                    case "Author":
                        Console.WriteLine($"Author: {GetAttributeData("Author")}");
                        break;
                    case "Revision":
                        Console.WriteLine($"Revision: {GetAttributeData("Revision")}");
                        break;
                    case "Description":
                        Console.WriteLine($"Class description: {GetAttributeData("Description")}");
                        break;
                    case "Reviewers":
                        Console.WriteLine($"Reviewers: {GetAttributeData("Reviewers")}");
                        break;
                }
            }
        }

        private static string GetAttributeData(string property)
        {
            var attribute = (CustomClassAttribute)typeof(Weapon)
                .GetCustomAttributes(typeof(CustomClassAttribute), false)
                .FirstOrDefault();

            if (attribute == null)
                return "No attribute found.";

            return property switch
            {
                "Author" => attribute.Author,
                "Revision" => attribute.Revision.ToString(),
                "Description" => attribute.Description,
                "Reviewers" => string.Join(", ", attribute.Reviewers),
                _ => "Invalid property"
            };
        }
    }
}
