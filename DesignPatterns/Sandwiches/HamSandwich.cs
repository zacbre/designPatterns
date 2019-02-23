using SandwichFactory.Ingredients;

namespace SandwichFactory.Sandwiches
{
    public class HamSandwich : Sandwich
    {
        public override void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new Cheese());
            Ingredients.Add(new Ham());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Tomato());
            Ingredients.Add(new Bread());
        }
    }
}