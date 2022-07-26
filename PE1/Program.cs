using System;
using static System.Console;

namespace PE1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x, y, z;
            DisplayInstructions();
            x = InputSales();
            y = CalculateProfitRatio(x);
            z = CalculateSales(x, y);
            DisplayResults(x, y, z);
        }

        public static void DisplayInstructions()
        {
            WriteLine("This program will determine the profit based on sales and will display it.");
            WriteLine("You will be asked to input the total amount of sales and from that, the profit ratio will");
            WriteLine("calculate the profit generated.");
            WriteLine("Press the spacebar to begin.");
            ReadKey();
        }

        public static decimal InputSales()
        {
            string inputValue;
            decimal value;
            WriteLine("Please input the total amount of sales: ");
            inputValue = ReadLine();
            if (decimal.TryParse(inputValue, out value) == false)
            {
                WriteLine("Bad Input!");
            }
            decimal.TryParse(inputValue, out value);
            return value;
        }

        public static decimal CalculateProfitRatio(decimal value)
        {
            decimal profitRatio = 0;

            if (value > 10000)
            {
                profitRatio = 0.045M;
            }
            else
                if (value < 0)
            {
                profitRatio = 0.0M;
            }
            else
                    if (value < 1000)
            {
                profitRatio = 0.03M;
            }
            else
                    if (value < 5000)
            {
                profitRatio = 0.035M;
            }
            else
                    if (value < 10000)
            {
                profitRatio = 0.04M;
            }

            return profitRatio;
        }

        public static decimal CalculateSales(decimal value, decimal profitRatio)
        {
            decimal profit;
            profit = profitRatio * value;
            return profit;
        }

        public static void DisplayResults(decimal value, decimal profitRatio, decimal profit)
        {
            Clear();
            WriteLine("\t\tSales Profit App\t\t\n\n");
            WriteLine("The sales amount you entered was: {0:C}", value);
            WriteLine("The profit ratio for this sales amount is: {0:P} ", profitRatio);
            WriteLine("The net proceeds are: {0:C} ", profit);
        }
    }
}
