using System;
using SandwichFactory.Ingredients;

namespace SandwichFactory.Sandwiches
{
    public class GarbageSandwich : Sandwich
    {
        public override void CreateIngredients()
        {
            Ingredients.Add(new Garbage());
        }

        public override void Eat()
        {
            Console.WriteLine("Gross! I can't eat that!");
        }
    }
}