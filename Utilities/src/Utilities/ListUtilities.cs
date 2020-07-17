using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Utilities
{
    public class ListUtilities
    {
        //https://docs.microsoft.com/en-us/globalization/locale/sorting-and-string-comparison
        public static bool IsInAlphabeticalOrder(IList<string> list)
        {
            var current = list.First();
            foreach (var item in list.Skip(1))
            {
                var next = item;
                var sc1 = CultureInfo.DefaultThreadCurrentCulture.CompareInfo.GetSortKey(current);
                var sc2 = CultureInfo.DefaultThreadCurrentCulture.CompareInfo.GetSortKey(next);
                var result = SortKey.Compare(sc1, sc2);

                // Assert.LessOrEqual(result, 0, $"Alphabetical order problem: {next} is before the {current}");
                if (result > 0)
                {
                    return false;
                }

                current = next;
            }

            return true;
        }
    }
}
