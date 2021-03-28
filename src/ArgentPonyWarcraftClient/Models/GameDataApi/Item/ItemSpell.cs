using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Gets a spell associated with an item.
    /// </summary>
    public record ItemSpell
    {
        /// <summary>
        /// Gets a reference to a spell.
        /// </summary>
        [JsonPropertyName("spell")]
        public SpellReference Spell { get; }

        /// <summary>
        /// Gets the description of the spell.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; }

        /// <summary>
        /// Gets the RGBA display color for the spell.
        /// </summary>
        [JsonPropertyName("display_color")]
        public ColorDetails DisplayColor { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemSpell"/> class.
        /// </summary>
        /// <param name="spell">A reference to a spell.</param>
        /// <param name="description">The description of the spell.</param>
        /// <param name="displayColor">The RGBA display color for the spell.</param>
        [JsonConstructor]
        public ItemSpell(SpellReference spell, string description, ColorDetails displayColor)
        {
            Spell = spell;
            Description = description;
            DisplayColor = displayColor;
        }
    }
}
