using System;
using System.Collections;
namespace AppleShop
{
    class AppleStore
    {
        static void Main (string[] args)
        {
            string greetings = "Welcome to Apple Store";
            foreach (char letter in greetings)
                {
                    Console.Write(letter);
                    Thread.Sleep(100); //Types the statement with a 100 milliseconds interval
                }
            Console.Write("\n\nEnter the number of apples you want to purchase: ");
            int numOfApple = Convert.ToInt32(Console.ReadLine());
            double priceOfApples = numOfApple * 32.50; // computes the price of apple(s)
            int convertedPrice = (int)priceOfApples; // converts the price into whole number

            //an "if" statements to correct the plurality of the word apple
            if (numOfApple == 1) //singular
            {
                Console.WriteLine($"The total price of {numOfApple.ToString()} apple is: {priceOfApples}.");
                Console.WriteLine($"The value of the converted price is {convertedPrice}.");
            }
            else if (numOfApple > 0) //plural
            {
                Console.WriteLine($"The total price of {numOfApple.ToString()} apples is: {priceOfApples}.");
                Console.WriteLine($"The value of the converted price is {convertedPrice}.");
            }
            else
            { // negative numbers or zero apple input
                Console.WriteLine("Unexpected input. Please try again.");
            }

        }
    }
}//made by January Toribio Jr