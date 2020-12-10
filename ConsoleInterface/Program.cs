using System;
using Box;
using Utils.Builders.GiftBox;

namespace ConsoleInterface
{
    class Program
    {
        private static void Main(string[] args)
        {
            Gift standardChristmasGift = new Creator().CreateGift(new StandardGiftBuilder());
            Console.WriteLine(standardChristmasGift);

            Console.WriteLine($"Total weight: {standardChristmasGift.CountWeight()}");

            standardChristmasGift.OrderByManufacturer();
            Console.WriteLine(standardChristmasGift);

            Console.WriteLine("Enter sugar content range: ");
            Console.Write("From: ");
            string fromString = Console.ReadLine();
            Console.Write("To: ");
            string toString = Console.ReadLine();
            if (int.TryParse(fromString, out int from) && int.TryParse(toString, out int to))
            {
                Console.WriteLine(standardChristmasGift.FindConfectionBySugarContent(from, to));
                foreach (var confection in standardChristmasGift.FindConfectionsBySugarContent(from, to))
                {
                    Console.WriteLine(confection);
                }
            }
            else
            {
                Console.WriteLine("Incorrect range");
            }
            
            Console.ReadKey();
        }
    }
}
