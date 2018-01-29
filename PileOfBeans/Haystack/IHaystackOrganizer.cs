﻿
namespace eBags.PileOfBeans.Haystack
{
    public interface IHaystackOrganizer
    {
        /// <summary>
        /// Sorts the haystack pile into color groups.
        /// </summary>
        /// <param name="haystack">The haystack instance containing the pile to be sorted.</param>
        /// <returns>Result containing the sorted, ordered lists of unique straws from the haystack.</returns>
        SortByColorResult SortByColor(Haystack haystack);
    }
}
