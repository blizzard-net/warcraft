using System.Collections.Generic;
using System.Linq;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A utility that builds a partial querystring to specify which guild fields to include.
    /// </summary>
    internal static class GuildFieldBuilder
    {
        /// <summary>
        /// Build a partial querystring to specify which guild fields to include.
        /// </summary>
        /// <param name="fields">The guild fields.</param>
        /// <returns>
        /// The partial querystring.
        /// </returns>
        internal static string BuildQueryString(GuildFields fields)
        {
            var flags = new List<string>();

            if (fields.HasFlag(GuildFields.Achievements))
            {
                flags.Add("achievements");
            }

            if (fields.HasFlag(GuildFields.Members))
            {
                flags.Add("members");
            }

            if (fields.HasFlag(GuildFields.Achievements))
            {
                flags.Add("achievements");
            }

            if (fields.HasFlag(GuildFields.News))
            {
                flags.Add("news");
            }

            if (fields.HasFlag(GuildFields.Challenge))
            {
                flags.Add("challenge");
            }

            return flags.Any()
                ? $"&fields={string.Join(",", flags)}"
                : string.Empty;
        }
    }
}
