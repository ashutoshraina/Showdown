using System;
using System.Collections.Generic;
using Nancy;
using Showdown.Model;
using System.Linq;

namespace Showdown.Nancy.Modules
{
    public class TipsModule : BaseModule
    {
        private static List<Tip> Tips { get; set; }

        public TipsModule() : base("tips")
        {
            Get["/list"] = 
                parameter =>
                {
                    // this should basically show the latest created/modified tips ( say 30 )
                    //, may be we could do paging as well.
                    return View["/Tips/Index", GetTips()];
                };

            Get["/create"] = 
                parameter =>
                {
                    return View["Tips/Create"];
                };

            Post["/create"] = 
                parameter =>
                {
                    // Get the values from the form and add them to the Tips.
                    // Let's go back to the Index , or in future , stay on Create and show a notification
                    return Response.AsRedirect ( "/tips/list" );
                };

            Get["/edit/{id}"] =
                parameter =>
                {
                    var result = GetTips().Single(tip => tip.Id == parameter.id);
                    return View["Tips/Edit", result];
                };

            Post["/edit/{id}"] =
                parameter =>
                {
                    var id = parameter.id;
                    var content = Request.Form["content"];
                    var result = GetTips().Single ( tip => tip.Id == id );
                    result.Content = content;
                    result.CreatedOn = DateTime.UtcNow.Date;
                    return Response.AsRedirect("/tips/list");
                };

            Delete["/delete/{id}"] =
                parameter =>
                {
                    var id = parameter.id;
                    //do the deletion here
                    return Response.AsRedirect("/tips/list");
                };

            Get["/search"] =
                parameter =>
                {
                    return View["/Tips/Search",null];
                };

            Post["/search/"] =
                parameter =>
                {
                    if(Request.Form["content"] != null)
                        return View["Tips/Search", SearchTips(Request.Form["content"])];
                    return View["Tips/Search", null];
                };
        }

        private List<Tip> SearchTips(string content)
        {
            var result =  GetTips().Where(tip => tip.Content.Contains(content)).ToList();
            return result;
        }

        private List<Tip> GetTips()
        {
            return Tips = new List<Tip>
                   {
                       new Tip{Id = 1 , Type = TipType.Breads, Content = "This is an awesome Bread Tip",
                       CreatedOn = DateTime.UtcNow.Date},
                       new Tip{Id = 2 , Type = TipType.Cakes, Content = "This is an awesome Cake Tip",
                       CreatedOn = DateTime.UtcNow.Date}
                   };
        }

        private List<Tip> AddTip(Tip tip)
        {
            Tips.Add(tip);
            return Tips;
        }
    }
}