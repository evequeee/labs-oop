using System;

class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

class Rectangle
{
    public Point TopLeft { get; set; }
    public Point BottomRight { get; set; }

    public Rectangle(Point topLeft, Point bottomRight)
    {
        TopLeft = topLeft;
        BottomRight = bottomRight;
    }

    public bool Contains(Point point)
    {
        return point.X >= TopLeft.X && point.X <= BottomRight.X &&
               point.Y >= TopLeft.Y && point.Y <= BottomRight.Y;
    }

    class Program
    {
        static void Main()
        {
            string[] rectangleInput = Console.ReadLine().Split();
            int topLeftX = int.Parse(rectangleInput[0]);
            int topLeftY = int.Parse(rectangleInput[1]);
            int bottomRightX = int.Parse(rectangleInput[2]);
            int bottomRightY = int.Parse(rectangleInput[3]);

            Point topLeft = new Point(topLeftX, topLeftY);
            Point bottomRight = new Point(bottomRightX, bottomRightY);
            Rectangle rectangle = new Rectangle(topLeft, bottomRight);

            int n = int.Parse(Console.ReadLine()); //кількість точок n з консолі та перетворення на ціле число

            for (int i = 0; i < n; i++) //// Введення точок і перевірка, чи вони всередині прямокутника
            {
                string[] pointInput = Console.ReadLine().Split();
                int pointX = int.Parse(pointInput[0]);
                int pointY = int.Parse(pointInput[1]);

                Point point = new Point(pointX, pointY);

                Console.WriteLine(rectangle.Contains(point) ? "True" : "False");
            }
        }
    }
}