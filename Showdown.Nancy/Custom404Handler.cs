using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using Nancy.ErrorHandling;
using Nancy.ViewEngines;

namespace Showdown.Nancy
{
    public class Custom404Handler : IStatusCodeHandler
    {
        private readonly IViewFactory _viewFactory;

        public Custom404Handler(IViewFactory viewFactory)
        {
            if (viewFactory == null)
            {
                throw new ArgumentNullException("viewFactory");
            }

            _viewFactory = viewFactory;
        }

        public void Handle(HttpStatusCode statusCode, NancyContext context)
        {
            var viewRenderer = new DefaultViewRenderer(_viewFactory);
            var response = viewRenderer.RenderView(context, "404");
            context.Response = response;
            context.Response.StatusCode = HttpStatusCode.NotFound;
        }

        public bool HandlesStatusCode(HttpStatusCode statusCode, NancyContext context)
        {
            return statusCode == HttpStatusCode.NotFound;
        }
    }
}