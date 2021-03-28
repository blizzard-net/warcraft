using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of a character's appearance settings.
    /// </summary>
    public record CharacterAppearanceSummary
    {
        /// <summary>
        /// Gets links for the character appearance summary.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; }

        /// <summary>
        /// Gets a reference to the character's race.
        /// </summary>
        [JsonPropertyName("playable_race")]
        public PlayableRaceReference PlayableRace { get; }

        /// <summary>
        /// Gets a reference to the character's class.
        /// </summary>
        [JsonPropertyName("playable_class")]
        public PlayableClassReference PlayableClass { get; }

        /// <summary>
        /// Gets a reference to the character's active specialization.
        /// </summary>
        [JsonPropertyName("active_spec")]
        public PlayableSpecializationReference ActiveSpec { get; }

        /// <summary>
        /// Gets the character's gender.
        /// </summary>
        [JsonPropertyName("gender")]
        public EnumType Gender { get; }

        /// <summary>
        /// Gets the character's faction (Alliance or Horde).
        /// </summary>
        [JsonPropertyName("faction")]
        public EnumType Faction { get; }

        /// <summary>
        /// Gets the guild crest of the character's guild.
        /// </summary>
        [JsonPropertyName("guild_crest")]
        public GuildCrest GuildCrest { get; }

        /// <summary>
        /// Gets the settings related to the character's appearance.
        /// </summary>
        [JsonPropertyName("appearance")]
        public Appearance Appearance { get; }

        /// <summary>
        /// Gets the character's equipped items.
        /// </summary>
        [JsonPropertyName("items")]
        public EquippedItemAppearance[] Items { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterAppearanceSummary"/> class.
        /// </summary>
        /// <param name="links">Links for the character appearance summary.</param>
        /// <param name="character">A reference to the character.</param>
        /// <param name="playableRace">A reference to the character's race.</param>
        /// <param name="playableClass">A reference to the character's class.</param>
        /// <param name="activeSpec">A reference to the character's active specialization.</param>
        /// <param name="gender">The character's gender.</param>
        /// <param name="faction">The character's faction (Alliance or Horde).</param>
        /// <param name="guildCrest">The guild crest of the character's guild.</param>
        /// <param name="appearance">The settings related to the character's appearance.</param>
        /// <param name="items">The character's equipped items.</param>
        [JsonConstructor]
        public CharacterAppearanceSummary(Links links, CharacterReference character, PlayableRaceReference playableRace, PlayableClassReference playableClass, PlayableSpecializationReference activeSpec, EnumType gender, EnumType faction, GuildCrest guildCrest, Appearance appearance, EquippedItemAppearance[] items)
        {
            Links = links;
            Character = character;
            PlayableRace = playableRace;
            PlayableClass = playableClass;
            ActiveSpec = activeSpec;
            Gender = gender;
            Faction = faction;
            GuildCrest = guildCrest;
            Appearance = appearance;
            Items = items;
        }
    }
}
