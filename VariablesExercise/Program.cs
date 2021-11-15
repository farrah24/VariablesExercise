using System;

namespace VariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ralph";
            int dogAge = 10;
            char legs = 'l';
            bool furry = true;
            double tail = 5.3;
            decimal eyes = 3.5m;
            Console.WriteLine("string name = " + name);
            Console.WriteLine("int dogAge = " + dogAge.ToString());
            Console.WriteLine($"My dog's name is {name}, He is {dogAge} years old");

         


        }
    }
}
