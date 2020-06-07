using System;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A World of Warcraft player character.
    /// </summary>
    public class CharacterProfileSummary
    {
        /// <summary>
        /// Gets links for the character.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the character.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the character.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the gender of the character.
        /// </summary>
        [JsonProperty("gender")]
        public EnumType Gender { get; set; }

        /// <summary>
        /// Gets the faction of the character (Alliance or Horde).
        /// </summary>
        [JsonProperty("faction")]
        public EnumType Faction { get; set; }

        /// <summary>
        /// Gets the race of the character.
        /// </summary>
        [JsonProperty("race")]
        public PlayableRaceReference Race { get; set; }

        /// <summary>
        /// Gets the class of the character.
        /// </summary>
        [JsonProperty("character_class")]
        public PlayableClassReference CharacterClass { get; set; }

        /// <summary>
        /// Gets the active spec for the character.
        /// </summary>
        [JsonProperty("active_spec")]
        public PlayableSpecializationReference ActiveSpec { get; set; }

        /// <summary>
        /// Gets a reference to the character's realm.
        /// </summary>
        [JsonProperty("realm")]
        public RealmReference Realm { get; set; }

        /// <summary>
        /// Gets a reference to the character's guild.
        /// </summary>
        [JsonProperty("guild", NullValueHandling = NullValueHandling.Ignore)]
        public GuildReference Guild { get; set; }

        /// <summary>
        /// Gets the level of the character.
        /// </summary>
        [JsonProperty("level")]
        public long Level { get; set; }

        /// <summary>
        /// Gets the character's experience points.
        /// </summary>
        [JsonProperty("experience")]
        public long Experience { get; set; }

        /// <summary>
        /// Gets the number of achievement points the character has earned.
        /// </summary>
        [JsonProperty("achievement_points")]
        public long AchievementPoints { get; set; }

        /// <summary>
        /// Gets a link to the character's achievements.
        /// </summary>
        [JsonProperty("achievements")]
        public Self Achievements { get; set; }

        /// <summary>
        /// Gets a link to the character's titles.
        /// </summary>
        [JsonProperty("titles")]
        public Self Titles { get; set; }

        /// <summary>
        /// Gets a link to the character's PVP summary.
        /// </summary>
        [JsonProperty("pvp_summary")]
        public Self PvpSummary { get; set; }

        /// <summary>
        /// Gets a link to the character's encounters.
        /// </summary>
        [JsonProperty("encounters")]
        public Self Encounters { get; set; }

        /// <summary>
        /// Gets a link to the media for this character.
        /// </summary>
        [JsonProperty("media")]
        public Self Media { get; set; }

        /// <summary>
        /// Gets the last login timestamp for the character.
        /// </summary>
        [JsonProperty("last_login_timestamp")]
        public DateTime LastLoginTimestamp { get; set; }

        /// <summary>
        /// Gets the character's average item level.
        /// </summary>
        [JsonProperty("average_item_level")]
        public long AverageItemLevel { get; set; }

        /// <summary>
        /// Gets the character's equipped item level.
        /// </summary>
        [JsonProperty("equipped_item_level")]
        public long EquippedItemLevel { get; set; }

        /// <summary>
        /// Gets a link to the character's specializations.
        /// </summary>
        [JsonProperty("specializations")]
        public Self Specializations { get; set; }

        /// <summary>
        /// Gets a link to the character's statistics.
        /// </summary>
        [JsonProperty("statistics")]
        public Self Statistics { get; set; }

        /// <summary>
        /// Gets a link to the character's mythic keystone profile.
        /// </summary>
        [JsonProperty("mythic_keystone_profile")]
        public Self MythicKeystoneProfile { get; set; }

        /// <summary>
        /// Gets a link to the character's equipment.
        /// </summary>
        [JsonProperty("equipment")]
        public Self Equipment { get; set; }

        /// <summary>
        /// Gets a link to the character's appearance.
        /// </summary>
        [JsonProperty("appearance")]
        public Self Appearance { get; set; }

        /// <summary>
        /// Gets a link to the character's collections.
        /// </summary>
        [JsonProperty("collections")]
        public Self Collections { get; set; }

        [JsonProperty("active_title")]
        public TitleReference ActiveTitle { get; set; }

        /// <summary>
        /// Gets a link to the character's reputations.
        /// </summary>
        [JsonProperty("reputations")]
        public Self Reputations { get; set; }

        /// <summary>
        /// Gets a link to the character's quests.
        /// </summary>
        [JsonProperty("quests")]
        public Self Quests { get; set; }

        /// <summary>
        /// Gets a link to the character's achievement statistics.
        /// </summary>
        [JsonProperty("achievements_statistics")]
        public Self AchievementsStatistics { get; set; }

        /// <summary>
        /// Gets a link to the character's professions.
        /// </summary>
        [JsonProperty("professions")]
        public Self Professions { get; set; }
    }
}
