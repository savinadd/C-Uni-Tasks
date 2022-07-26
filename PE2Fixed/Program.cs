using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Windows.Forms;


namespace PE2Fixed
{
    class Program
    {
        static void Main(string[] args)
        {
            string purchases = "";
            int purchaseAmount = 0;
            double purchaseInt = 0;
            double purchaseTotal = 0;

            while (purchases != "-99")
            {
                WriteLine("Enter in your purchase amount or enter -99 to exit:");
                purchases = ReadLine();
                purchaseInt = double.Parse(purchases);
                purchaseTotal = purchaseInt + purchaseTotal;
                purchaseAmount++;

                if (purchases == "-99")
                {
                    purchaseAmount--;
                    purchaseInt = purchaseInt + 99;
                    purchaseTotal = purchaseTotal + 99;
                }
            }


            double tax = 0.075;
            double salesTax = 0;
            salesTax = purchaseTotal * tax;
            double x = 0;
            x = ShipCost(purchaseTotal);
            DisplayResults(x, purchaseAmount, purchaseTotal, salesTax);
        }

        public static double ShipCost(double purchaseTotal)
        {
            double shippingCharge = 0;

            if (purchaseTotal < 3)
            {
                shippingCharge = 3.50;
            }
            else
                if (purchaseTotal < 7)
            {
                shippingCharge = 5;
            }
            else
                if (purchaseTotal < 11)
            {
                shippingCharge = 7;
            }
            else
                if (purchaseTotal < 16)
            {
                shippingCharge = 9;
            }
            else
                if (purchaseTotal > 16)
            {
                shippingCharge = 10;
            }

            return shippingCharge;
        }
        public static void DisplayResults(double shippingCharge, int purchaseAmount, double purchaseTotal, double salesTax)
        {
            WriteLine("Total Purchase Amount: {0:C} ", purchaseTotal);
            WriteLine("Sales Tax: {0:C} ", salesTax);
            WriteLine("Number of items purchased: {0:C}", purchaseAmount);
            WriteLine("Shipping Charge: {0:C}", shippingCharge);

            double grandTotal = purchaseTotal + salesTax + shippingCharge;

            WriteLine("Grand total: {0:C}", grandTotal);

        }

    }





}
   
   
      
        

    