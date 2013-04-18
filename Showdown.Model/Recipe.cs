using System.Collections.Generic;

namespace Showdown.Model
{
    public class Recipe
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<string> Category { get; set; }

        public string Content { get; set; }

        public IEnumerable<Ingredient> Ingredients { get; set; }

        public string RecipeImageUrl { get; set; }

    }
}
