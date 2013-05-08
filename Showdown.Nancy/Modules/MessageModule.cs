using System.Collections.Generic;
using Nancy;
using Showdown.Model;

namespace Showdown.Nancy.Modules
{

    public class MessageModule : BaseModule
    {
        public MessageModule() : base("messages")
        {
            
            Model = GetMessages();

            Get["/list"] = 
                parameters =>
                {
                    return View["/Message/Index", Model];
                };

            Get["/unread"] = 
                parameters =>
                {
                    return View["/Message/Unread", Model];
                };

            Post["/response"] = 
                parameters =>
                {
                    var message = Request.Form["message"];
                    
                    return HttpStatusCode.OK;
                };
        }

        private List<Message> GetMessages()
        {
            var message = new Message
            {
                Id = 1,
                Name = "ashutosh",
                Email = "ashutoshraina1989@gmail.com",
                MessageContent = @"Nullam quis risus eget urna mollis ornare vel eu leo. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. 
                                   Nullam id dolor id nibh ultricies vehicula ut id elit.Vivamus sagittis lacus vel augue laoreet rutrum faucibus dolor auctor. 
                                   Duis mollis, est non commodo luctus, nisi erat porttitor ligula, eget lacinia odio sem nec elit. Donec sed odio dui."
            };
            var message2 = new Message
            {
                Id = 1,
                Name = "Awesome",
                Email = "awesomeness@gmail.com",
                MessageContent = "Wassup Baker"
            };

            return  new List<Message> { message, message2 };
        }
    }
}