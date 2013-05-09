using System.Collections.Generic;
using System.Dynamic;
using System.Web.Routing;

namespace Showdown.Nancy.Modules
{
    public static class Awesome
    {
        public static ExpandoObject ToExpando(this object anonymousObject)
        {
            IDictionary<string, object> anonymousDictionary = new RouteValueDictionary(anonymousObject);
            IDictionary<string, object> expando = new ExpandoObject();
            foreach (var item in anonymousDictionary)
                expando.Add(item);
            return (ExpandoObject) expando;
        }
    }

    public class ReviewModule : BaseModule
    {
        public ReviewModule() : base("review")
        {
            Get["/list"] =
                parameter =>
                {
                    IEnumerable<dynamic> items = new List<dynamic>
                                                 {
                                                     new {name = "foo", age = 10}.ToExpando(),
                                                     new {name = "bar", age = 10}.ToExpando()
                                                 };

                    return View["/Reviews/Index", items];
                };
            Get["/create"] =
                parameter => { return View["/Reviews/Create"]; };
            Post["/create"] =
                parameter => { return View["/Reviews/Create"]; };
            Delete["/delete/{id}"] =
                parameter => { return View["/Reviews/Index"]; };
        }
    }
}