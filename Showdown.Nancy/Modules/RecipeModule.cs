using System.Collections.Generic;
using Nancy;
using Showdown.Model;

namespace Showdown.Nancy.Modules
{
    public class RecipeModule : NancyModule
    {
        public RecipeModule() : base("/recipe")
        {
            Get["/list"] = parameter =>
                           {
                             return View["/recipes/Index",GetRecipes()];
                           };
            Post["/create"] = parameter =>
                            {
                            return null;
                            };
        }

        private List<Recipe> GetRecipes()
        {
        return new List<Recipe>
                   {
                       new Recipe{
                                    Id = 1 , 
                                    Name = "Spinach Awesomeness" , 
                                    Category = new List<string>{"Veg, Non-Veg, Vegan"},
                                    Content = " I have no idea what the content should be, let puri figure it out.",
                                    Ingredients = new List<Ingredient>{new Ingredient{Name="Spinach", Quantity="500gm"}},
                                    RecipeImageUrl = "I don't have anything right now"
                                  },
                        new Recipe{
                                    Id = 2 , 
                                    Name = "Potato Awesomeness" , 
                                    Category = new List<string>{"Veg, Non-Veg, Vegan"},
                                    Content = " I have no idea what the content should be, let puri figure it out.",
                                    Ingredients = new List<Ingredient>{new Ingredient{Name="Potato", Quantity="500gm"}},
                                    RecipeImageUrl = "I don't have anything right now"
                                  }
                   };
        }
    }
}