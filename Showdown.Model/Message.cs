
namespace Showdown.Model
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
}
