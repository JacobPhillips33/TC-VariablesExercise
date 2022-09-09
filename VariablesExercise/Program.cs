using System;

namespace VariablesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Eve";
            int dogAge = 9;
            char dollarSign = '$';
            bool isDog = true;
            double dogWeight = 45.5;
            decimal foodCost = 68.33m;

            Console.WriteLine($"My dog's name is {dogName}. She is {dogAge} years old, and she weighs {dogWeight} pounds. " +
                $"Her food costs {dollarSign}{foodCost}. True or false, does she love to play fetch? {isDog}.");
        }
    }
}
