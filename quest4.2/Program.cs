using System;

public enum Season
{
    Autumn = 1,
    Spring = 2,
    Winter = 3,
    Summer = 4
}

public enum DiscountType
{
    None = 0,
    SecondVisit = 10,
    VIP = 20
}

public class PriceCalculator
{
    public static decimal CalculatePrice(decimal pricePerDay, int numberOfDays, Season season, DiscountType discountType)
    {
        decimal basePrice = pricePerDay * numberOfDays;
        decimal seasonMultiplier = (decimal)season;
        decimal discountMultiplier = 1 - ((decimal)discountType / 100);

        decimal totalPrice = basePrice * seasonMultiplier * discountMultiplier;
        return Math.Round(totalPrice, 2);
    }
}
public class Program
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split();
        decimal pricePerDay = decimal.Parse(input[0]);
        int numberOfDays = int.Parse(input[1]);
        Season season = (Season)Enum.Parse(typeof(Season), input[2], true);
        DiscountType discountType = input.Length > 3 ? (DiscountType)Enum.Parse(typeof(DiscountType), input[3], true) : DiscountType.None;

        decimal totalPrice = PriceCalculator.CalculatePrice(pricePerDay, numberOfDays, season, discountType);

        Console.WriteLine(totalPrice);
    }
}