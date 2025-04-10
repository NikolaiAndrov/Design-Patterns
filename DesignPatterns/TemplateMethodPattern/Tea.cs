﻿namespace TemplateMethodPattern
{
    public class Tea : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Brewing tea for 3 minutes.");
        }

        protected override void AddCondiments()
        {
            if (AreCondimentsNeeded())
            {
                Console.WriteLine("Adding lemon to the tea.");
            }
        }

        private bool AreCondimentsNeeded()
        {
            Console.WriteLine("Would you like some lemon? (y/n)");
            string input = Console.ReadLine()!;
            return input.ToLower() == "y";
        }
    }
}
