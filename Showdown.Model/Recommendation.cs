
namespace Showdown.Model
{
    public class Recommendation
    {
        public int Id { get; set; }

        public RecommendationType RecommendationType { get; set; }

        public string Content { get; set; }

        public string Reason { get; set; }

    }

    public enum RecommendationType
    {
        Buy,
        Eat
    }
}
