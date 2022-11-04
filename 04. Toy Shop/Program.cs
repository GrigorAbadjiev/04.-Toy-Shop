using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double trip = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int talkingDolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double price = (puzzles * 2.60) + (talkingDolls * 3) +
                (teddyBears * 4.10) + (minions * 8.20) + (trucks * 2);

            double totalOrders = puzzles + talkingDolls + teddyBears + minions + trucks;
            double discount = 0.25;
            double rent = 0.1;
            double sumAfterDiscountAndRent = (price - (price * discount)) - ((price - (price * discount)) * rent);
            double sumAfterRent = price - (price * rent);
            if (totalOrders >= 50)
            {
                Console.WriteLine($"Yes! {sumAfterDiscountAndRent - trip :f2} lv left.");
            }
            else
            {
                if (sumAfterRent > trip)
                    Console.WriteLine($"Not enough money! {sumAfterRent - trip :f2} lv needed.");
                else
                    Console.WriteLine($"Not enough money! {trip - sumAfterRent:f2} lv needed.");
            }
            


            


        }
    }
}
