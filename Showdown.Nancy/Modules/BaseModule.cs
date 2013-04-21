using Nancy;
using Showdown.Nancy.Models;
using System.Dynamic;

namespace Showdown.Nancy.Modules
{
    public class BaseModule : NancyModule
    {
        public dynamic Model = new ExpandoObject();

        public dynamic Query { get { return Request.Query; } }
        
        public dynamic Form { get { return Request.Form; } }

        protected PageModel Page { get; set; }

        public BaseModule()
        {
            SetupModelDefaults();
        }
        
        public BaseModule(string modulepath): base(modulepath)
        {
            SetupModelDefaults();
        }

        private void SetupModelDefaults()
        {
            Before += ctx =>
                {
                    Page = new PageModel
                        {
                            IsAuthenticated = ctx.CurrentUser != null,
                            PreFixTitle = "Showdown Nancy - ",
                            CurrentUser = ctx.CurrentUser != null ? ctx.CurrentUser.UserName : ""
                        };
                    return null;
                };
        }

    }
}