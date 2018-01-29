using System.Collections.Generic;

namespace eBags.PileOfBeans.Haystack
{
    public class SortByColorResult
    {
        public IList<Straw> Reds { get; set; }
        public IList<Straw> Greens { get; set; }
        public IList<Straw> Blues { get; set; }
        public IList<Straw> Grays { get; set; }
    }
}
