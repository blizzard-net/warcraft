using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of a character's appearance settings.
    /// </summary>
    public class CharacterAppearanceSummary
    {
        /// <summary>
        /// Gets links for the character appearance summary.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonProperty("character")]
        public CharacterReference Character { get; set; }

        /// <summary>
        /// Gets a reference to the character's race.
        /// </summary>
        [JsonProperty("playable_race")]
        public PlayableRaceReference PlayableRace { get; set; }

        /// <summary>
        /// Gets a reference to the character's class.
        /// </summary>
        [JsonProperty("playable_class")]
        public PlayableClassReference PlayableClass { get; set; }

        /// <summary>
        /// Gets a reference to the character's active specialization.
        /// </summary>
        [JsonProperty("active_spec")]
        public PlayableSpecializationReference ActiveSpec { get; set; }

        /// <summary>
        /// Gets the character's gender.
        /// </summary>
        [JsonProperty("gender")]
        public EnumType Gender { get; set; }

        /// <summary>
        /// Gets the character's faction (Alliance or Horde).
        /// </summary>
        [JsonProperty("faction")]
        public EnumType Faction { get; set; }

        /// <summary>
        /// Gets the guild crest of the character's guild.
        /// </summary>
        [JsonProperty("guild_crest")]
        public GuildCrest GuildCrest { get; set; }

        /// <summary>
        /// Gets the settings related to the character's appearance.
        /// </summary>
        [JsonProperty("appearance")]
        public Appearance Appearance { get; set; }

        /// <summary>
        /// Gets the character's equipped items.
        /// </summary>
        [JsonProperty("items")]
        public EquippedItemAppearance[] Items { get; set; }
    }
}
