using System.Collections.Generic;
using Nancy;
using Showdown.Model;

namespace Showdown.Nancy.Modules
{
    public class RecommendModule : NancyModule
    {
        public RecommendModule() : base("recommend")
        {
            Get["/list"] = parameter =>
                           {
                               return View["/recommend/Index", GetRecommendations()];
                           };
            Put["/"] = parameter =>
                       {
                           return Request.Form["Id"];
                       };
        }

        private dynamic GetRecommendations()
        {
        return new List<Recommendation>
                   {
                       new Recommendation{Id = 1, Content = "This is an awesome recommendation", 
                                          Reason = "Becuase I feel like it", RecommendationType = RecommendationType.Buy},
                       new Recommendation{Id = 2, Content = "This is an awesome recommendation", 
                                          Reason = "Becuase I feel like it", RecommendationType = RecommendationType.Eat}
                   };
        }
    }
}