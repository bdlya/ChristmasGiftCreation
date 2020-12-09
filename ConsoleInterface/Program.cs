using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Box;
using Utils.Builders.GiftBox;

namespace ConsoleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Gift standardChristmasGift = new Creator().CreateGift(new StandardGiftBuilder());
            Console.WriteLine(standardChristmasGift);

            Console.WriteLine($"Total weight: {standardChristmasGift.CountWeight()}");

            Console.WriteLine(standardChristmasGift.OrderByManufacturer());

            Console.WriteLine("Enter sugar content range: ");
            Console.Write("From: ");
            int from = int.Parse(Console.ReadLine());
            Console.Write("To: ");
            int to = int.Parse(Console.ReadLine());
            Console.WriteLine(standardChristmasGift.FindConfectionsBySugarContent(from, to));

            Console.ReadKey();
        }
    }
}
