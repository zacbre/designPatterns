using System;
using System.Collections.Generic;

namespace SandwichFactory
{
    public abstract class Sandwich
    {
        public List<Ingredient> Ingredients { get; set; }

        public Sandwich()
        {
            Ingredients = new List<Ingredient>();
            CreateIngredients();
        }

        public void PrintIngredients()
        {
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine(ingredient.GetType().ToString());
            }
        }

        public virtual void Eat()
        {
            Console.WriteLine($"Yum, this {this.GetType().ToString()} is good!");
        }

        public abstract void CreateIngredients();
    }
}