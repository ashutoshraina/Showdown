using System.Collections.Generic;

namespace Showdown.Model
{
    public enum Category
    {
        Veg,
        Cakes,
        Pastry,
        Vegan,
        NonVeg
    }

    public class Recipe
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Category Category { get; set; }

        public string Content { get; set; }

        public IEnumerable<Ingredient> Ingredients { get; set; }

        public string RecipeImageUrl { get; set; }

    }
}
