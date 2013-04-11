using Nancy;

namespace Showdown.Nancy
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ =>
            {
                dynamic viewBag = new DynamicDictionary();
                viewBag.WelcomeMessage = "Welcome to Nancy!";
                return View["home", viewBag];
            };
        }
    }
}