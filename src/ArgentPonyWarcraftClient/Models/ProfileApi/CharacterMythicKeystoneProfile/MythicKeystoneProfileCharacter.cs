using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Key details about the character for a Mythic Keystone profile.
    /// </summary>
    public class MythicKeystoneProfileCharacter
    {
        /// <summary>
        /// Gets the key for the character.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the character.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the character.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets a reference to the character's realm.
        /// </summary>
        [JsonProperty("realm")]
        public RealmReference Realm { get; set; }
    }
}
