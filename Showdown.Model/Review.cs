
namespace Showdown.Model
{
    public class Review
    {
        public int Id { get; set; }

        public Restaurant Restaurant { get; set; }

        public int Rating { get; set; }

        public string Content { get; set; }
    }

}
