using System.Collections.Generic;
using System.Linq;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A utility that builds a partial querystring to specify which character fields to include.
    /// </summary>
    internal static class CharacterFieldBuilder
    {
        /// <summary>
        /// Build a partial querystring to specify which character fields to include.
        /// </summary>
        /// <param name="fields">The character fields.</param>
        /// <returns>
        /// The partial querystring.
        /// </returns>
        internal static string BuildQueryString(CharacterFields fields)
        {
            var flags = new List<string>();

            if (fields.HasFlag(CharacterFields.Achievements))
            {
                flags.Add("achievements");
            }

            if (fields.HasFlag(CharacterFields.Appearance))
            {
                flags.Add("appearance");
            }

            if (fields.HasFlag(CharacterFields.Feed))
            {
                flags.Add("feed");
            }

            if (fields.HasFlag(CharacterFields.Guild))
            {
                flags.Add("guild");
            }

            if (fields.HasFlag(CharacterFields.HunterPets))
            {
                flags.Add("hunterPets");
            }

            if (fields.HasFlag(CharacterFields.Items))
            {
                flags.Add("items");
            }

            if (fields.HasFlag(CharacterFields.Mounts))
            {
                flags.Add("mounts");
            }

            if (fields.HasFlag(CharacterFields.Pets))
            {
                flags.Add("pets");
            }

            if (fields.HasFlag(CharacterFields.PetSlots))
            {
                flags.Add("petSlots");
            }

            if (fields.HasFlag(CharacterFields.Professions))
            {
                flags.Add("professions");
            }

            if (fields.HasFlag(CharacterFields.Progression))
            {
                flags.Add("progression");
            }

            if (fields.HasFlag(CharacterFields.Pvp))
            {
                flags.Add("pvp");
            }

            if (fields.HasFlag(CharacterFields.Quests))
            {
                flags.Add("quests");
            }

            if (fields.HasFlag(CharacterFields.Reputation))
            {
                flags.Add("reputation");
            }

            if (fields.HasFlag(CharacterFields.Statistics))
            {
                flags.Add("statistics");
            }

            if (fields.HasFlag(CharacterFields.Stats))
            {
                flags.Add("stats");
            }

            if (fields.HasFlag(CharacterFields.Talents))
            {
                flags.Add("talents");
            }

            if (fields.HasFlag(CharacterFields.Titles))
            {
                flags.Add("titles");
            }

            if (fields.HasFlag(CharacterFields.Audit))
            {
                flags.Add("audit");
            }

            return flags.Any()
                ? $"&fields={string.Join(",", flags)}"
                : string.Empty;
        }
    }
}
