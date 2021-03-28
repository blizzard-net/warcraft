using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A playable race.
    /// </summary>
    public record PlayableRace
    {
        /// <summary>
        /// Gets links for the playable race.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the playable race.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the playable race.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the gender-specific names for the playable race.
        /// </summary>
        [JsonPropertyName("gender_name")]
        public GenderName GenderName { get; }

        /// <summary>
        /// Gets the faction of the playable race (Alliance or Horde).
        /// </summary>
        [JsonPropertyName("faction")]
        public EnumType Faction { get; }

        /// <summary>
        /// Gets a value indicating whether the playable race can be selected.
        /// </summary>
        [JsonPropertyName("is_selectable")]
        public bool IsSelectable { get; }

        /// <summary>
        /// Gets a value indicating whether the race is allied to a faction.
        /// </summary>
        [JsonPropertyName("is_allied_race")]
        public bool IsAlliedRace { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayableRace"/> class.
        /// </summary>
        /// <param name="links">Links for the playable race.</param>
        /// <param name="id">The ID of the playable race.</param>
        /// <param name="name">The name of the playable race.</param>
        /// <param name="genderName">The gender-specific names for the playable race.</param>
        /// <param name="faction">The faction of the playable race (Alliance or Horde).</param>
        /// <param name="isSelectable">A value indicating whether the playable race can be selected.</param>
        /// <param name="isAlliedRace">A value indicating whether the race is allied to a faction.</param>
        [JsonConstructor]
        public PlayableRace(Links links, int id, string name, GenderName genderName, EnumType faction, bool isSelectable, bool isAlliedRace)
        {
            Links = links;
            Id = id;
            Name = name;
            GenderName = genderName;
            Faction = faction;
            IsSelectable = isSelectable;
            IsAlliedRace = isAlliedRace;
        }
    }
}
