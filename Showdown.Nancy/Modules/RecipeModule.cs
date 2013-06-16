using System.Collections.Generic;
using System.Linq;
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
                               var temp = GetRecipes();
                               var result = from r in temp
                                            group r by r.Category
                                            into groupedByCategory
                                            orderby groupedByCategory.Key
                                            select groupedByCategory;

                             return View["/recipes/Index",result];
                           };
            Get["/create"] = parameter =>
                            {
                            return View["/recipes/create"];
                            };
            Post["/create"] = parameter =>
                            {
                            return null;
                            };
            Put["/name"] = parameter =>
                            {
                                return null;
                            };
            Put["/category"] = parameter =>
                            {
                                return null;
                            };
            Put["/content"] = parameter =>
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
                                    Category = Category.Veg,
                                    Content = " I have no idea what the content should be, let puri figure it out.",
                                    Ingredients = new List<Ingredient>{new Ingredient{Name="Spinach", Quantity="500gm"}, new Ingredient{Name = "Flour" , Quantity = "250gm"}},
                                    RecipeImageUrl = "I don't have anything right now"
                                  },
                        new Recipe{
                                    Id = 2 , 
                                    Name = "Potato Awesomeness" , 
                                    Category = Category.Cakes,
                                    Content = " I have no idea what the content should be, let puri figure it out.",
                                    Ingredients = new List<Ingredient>{new Ingredient{Name="Potato", Quantity="500gm"}},
                                    RecipeImageUrl = "I don't have anything right now"
                                  },
                        new Recipe{
                        Id = 3 , 
                        Name = "Potato Awesomeness" , 
                        Category = Category.Cakes,
                        Content = " I have no idea what the content should be, let puri figure it out.",
                        Ingredients = new List<Ingredient>{new Ingredient{Name="Potato", Quantity="500gm"}},
                        RecipeImageUrl = "I don't have anything right now"
                        }
                   };
        }
    }
}