using Nancy;

namespace Showdown.Nancy.Modules
{
    public class HomeModule : BaseModule
    {
        public HomeModule()
        {
            Get["/"] = _ =>
                {
                    Page.Title = Page.PreFixTitle + "Index";
                    return View["/Home/Index",Page];
            };
        }
    }
}