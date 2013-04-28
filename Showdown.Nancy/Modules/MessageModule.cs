using System.Collections.Generic;
using Nancy;

namespace Showdown.Nancy.Modules
{
    public class Message
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string MessageContent { get; set; }

        public bool HasBeenRead { get; set; }

        public string Response { get; set; }
    }

    public class MessageModule : BaseModule
    {
        public MessageModule() : base("messages")
        {
            var message = new Message
                        {
                            Id = 1 , 
                            Name = "ashutosh", 
                            Email= "ashutoshraina1989@gmail.com",
                            MessageContent ="Wassup Baker"
                        };
            var message2 = new Message
            {
                Id = 1,
                Name = "Awesome",
                Email = "awesomeness@gmail.com",
                MessageContent = "Wassup Baker"
            };
            var messages = new List<Message> {message, message2};
            Model = messages;

            Get["/all"] = parameters =>
                {
                    return View["/Message/Index", messages];
                };

            Get["/unread"] = parameters =>
                {
                    return View["/Message/Unread", Model];
                };
            Post["/response"] = 
                parameters =>
                {
                    var stream = Request.Form["content"];
                    
                    return HttpStatusCode.OK;
                 };
        }
    }
}