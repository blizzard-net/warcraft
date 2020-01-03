namespace ArgentPonyWarcraftClient
{
    internal static class EnumFieldExtentions
    {
        public static string BuildQueryString(this CharacterFields fields)
        {
            // The Blizzard API only accepts lowercase fields.
            string flags = fields.ToString().ToLower();
            
            if (flags == "all")
            {
                return "&fields=achievements,appearance,feed,guild,hunter pets,items,mounts,pets,pet slots," +
                    "professions,progression,pvp,quests,reputation,statistics,stats,talents,titles";
            }
            if (flags == "none")
            {
                return string.Empty;
            }

            return ($"&fields={flags}");
        }

        public static string BuildQueryString(this GuildFields fields)
        {
            // The Blizzard API only accepts lowercase fields.
            string flags = fields.ToString().ToLower();

            if (flags == "all")
            {
                return "&fields=members,achievements,news,challenge";
            }
            if (flags == "none")
            {
                return string.Empty;
            }

            return ($"&fields={flags}");
        }
    }
}