using System.Collections.Generic;
using System.Linq;
using EnumsNET;

namespace ArgentPonyWarcraftClient
{
    internal static class EnumExtensions
    {
        public static string BuildQueryString(this CharacterFields fields)
        {
            IEnumerable<string> flags = fields.GetFlags().Select(t => t.GetMember().Name);

            return flags.Any()
                ? $"&fields={string.Join(",", flags)}"
                : string.Empty;
        }

        public static string BuildQueryString(this GuildFields fields)
        {
            IEnumerable<string> flags = fields.GetFlags().Select(t => t.GetMember().Name);

            return flags.Any()
                ? $"&fields={string.Join(",", flags)}"
                : string.Empty;
        }
    }
}