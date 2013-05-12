using System.Collections.Generic;

namespace Showdown.Model
{
    public class Restaurant
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public IEnumerable<string> PhoneNumber { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public IEnumerable<string> Images { get; set; }

        public IEnumerable<string> UsefulLinks { get; set; }

        public IEnumerable<Review> Review { get; set; }
    }
}