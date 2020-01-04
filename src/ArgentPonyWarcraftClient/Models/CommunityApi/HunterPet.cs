using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.Community
{
    /// <summary>
    /// A hunter pet.
    /// </summary>
    public class HunterPet
    {
        /// <summary>
        /// Gets or sets the pet name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the creature ID.
        /// </summary>
        [JsonProperty("creature")]
        public int Creature { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the pet is selected.
        /// </summary>
        [JsonProperty("selected")]
        public bool Selected { get; set; }

        /// <summary>
        /// Gets or sets the slot number.
        /// </summary>
        [JsonProperty("slot")]
        public int Slot { get; set; }

        /// <summary>
        /// Gets or sets the spec.
        /// </summary>
        [JsonProperty("spec")]
        public Spec Spec { get; set; }

        /// <summary>
        /// Gets or sets the calculated spec.
        /// </summary>
        [JsonProperty("calcSpec")]
        public string CalcSpec { get; set; }

        /// <summary>
        /// Gets or sets the family ID.
        /// </summary>
        [JsonProperty("familyId")]
        public int FamilyId { get; set; }

        /// <summary>
        /// Gets or sets the family name.
        /// </summary>
        [JsonProperty("familyName")]
        public string FamilyName { get; set; }
    }
}
