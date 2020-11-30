using System;
using BlApi;
using BO;
using BL;


namespace PlConsole
{
    class Program
    {
        static IBL bl;

        static void Main(string[] args)
        {
            // bl = BlFactory.GetBl();
            bl = new BlImp1();
            Console.Write("Please enter how many days back: ");
            int days = int.Parse(Console.ReadLine());
            for (int d = days; d >= 0; --d)
            {
                Weather w = bl.GetWeather(d);
                Console.WriteLine($"{d} days before - Feeling was: {w.Feeling} Celsius degrees");
            }

        }
    }
}