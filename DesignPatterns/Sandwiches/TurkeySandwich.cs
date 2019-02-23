using SandwichFactory.Ingredients;

namespace SandwichFactory.Sandwiches
{
    public class TurkeySandwich : Sandwich
    {
        public override void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Cheese());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Bread());
        }
    }
}