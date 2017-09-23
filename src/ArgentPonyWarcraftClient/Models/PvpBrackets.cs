using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// PvP Brackets.
    /// </summary>
    public class PvpBrackets
    {
        /// <summary>
        /// Gets or sets the Arena 2v2 bracket.
        /// </summary>
        [JsonProperty("ARENA_BRACKET_2v2")]
        public PvpBracket ArenaBracket2V2 { get; set; }

        /// <summary>
        /// Gets or sets the Arena 3v3 bracket.
        /// </summary>
        [JsonProperty("ARENA_BRACKET_3v3")]
        public PvpBracket ArenaBracket3V3 { get; set; }

        /// <summary>
        /// Gets or sets the Arena Rated Battleground bracket.
        /// </summary>
        [JsonProperty("ARENA_BRACKET_RBG")]
        public PvpBracket ArenaBracketRbg { get; set; }

        /// <summary>
        /// Gets or sets the Arena 2v2 Skirmish bracket.
        /// </summary>
        [JsonProperty("ARENA_BRACKET_2v2_SKIRMISH")]
        public PvpBracket ArenaBracket2V2Skirmish { get; set; }

        /// <summary>
        /// Gets or sets an unknown bracket.
        /// </summary>
        [JsonProperty("UNKNOWN")]
        public PvpBracket Unknown { get; set; }
    }
}
