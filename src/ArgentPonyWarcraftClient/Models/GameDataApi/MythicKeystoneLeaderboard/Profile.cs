using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character profile.
    /// </summary>
    public class Profile
    {
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
        public RealmReferenceWithoutName Realm { get; set; }
    }
}
