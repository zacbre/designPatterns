using System;
using SandwichFactory.Ingredients;
using SandwichFactory.Sandwiches;

namespace SandwichFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var turkeySandwich = new TurkeySandwich();
            turkeySandwich.PrintIngredients();
            turkeySandwich.Eat();
            
            Console.WriteLine("-------");
            
            var hamSandwich = new HamSandwich();
            hamSandwich.PrintIngredients();
            hamSandwich.Eat();
            
            Console.WriteLine("-------");
            
            var garbageSandwich = new GarbageSandwich();
            garbageSandwich.PrintIngredients();
            garbageSandwich.Eat();
        }
    }
}
