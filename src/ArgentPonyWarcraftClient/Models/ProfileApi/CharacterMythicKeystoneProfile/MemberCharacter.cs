using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character who is a party member.
    /// </summary>
    public class MemberCharacter
    {
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
        public RealmReferenceWithoutName Realm { get; set; }
    }
}
