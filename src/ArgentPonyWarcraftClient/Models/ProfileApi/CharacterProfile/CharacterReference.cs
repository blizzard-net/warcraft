using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a character.
    /// </summary>
    public class CharacterReference
    {
        /// <summary>
        /// Gets the key for the character.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the character.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the character.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets a reference to the character's realm.
        /// </summary>
        [JsonPropertyName("realm")]
        public RealmReference Realm { get; set; }
    }
}
