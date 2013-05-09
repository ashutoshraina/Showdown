namespace Showdown.Nancy.Modules
{
    public class RestaurentModule : BaseModule
    {
        public RestaurentModule() : base("restaurent")
        {
            Get["/list"] =
                parameter => { return View["/Restaurents/Index"]; };

            Get["/create"] =
                parameter => { return View["/Restaurents/Create"]; };

            Post["/create"] =
                parameter => { return View["/Restaurents/Create"]; };

            Delete["/delete/{id}"] =
                parameter => { return View["/Restaurents/Index"]; };
        }
    }
}