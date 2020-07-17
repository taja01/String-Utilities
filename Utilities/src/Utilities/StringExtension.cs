using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace Utilities
{
    public static class StringExtension
    {
        private const string CRY_REGEX = @"[A-Za-z]+\.[A-Za-z]";
        private const CompareOptions COMPARE_OPTIONS = CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace;

        public static bool HasHtmlTag(this string input)
        {
            var tagRegex = new Regex(@"<[^>]+>");
            return tagRegex.IsMatch(input);
        }

        public static bool IsCrsKeyLike(this string input)
        {
            var trimmed = input.Trim();
            return new Regex(CRY_REGEX).Match(trimmed).Success;
        }

        public static bool ContainsIgnoreCase(this string source, string toCheck)
        {
            var ci = CultureInfo.CurrentCulture.CompareInfo;
            return ci.IndexOf(source, toCheck, COMPARE_OPTIONS) != -1;
        }

        public static bool HasLowerLetter(this string text) => text.Any(char.IsLower);
    }
}
