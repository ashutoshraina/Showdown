
using System;

namespace Showdown.Model
{
    public class Tip
    {
        public int Id { get; set; }

        public TipType Type { get; set; }

        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }
    }

    public enum TipType
    {
        Pastry,
        Cakes,
        Breads
    }
}
