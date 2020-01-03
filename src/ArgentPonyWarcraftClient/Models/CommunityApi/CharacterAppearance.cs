using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Details about a character's appearance.
    /// </summary>
    public class CharacterAppearance
    {
        /// <summary>
        /// Gets or sets the face variation.
        /// </summary>
        [JsonProperty("faceVariation")]
        public int FaceVariation { get; set; }

        /// <summary>
        /// Gets or sets the skin color.
        /// </summary>
        [JsonProperty("skinColor")]
        public int SkinColor { get; set; }

        /// <summary>
        /// Gets or sets the hair variation.
        /// </summary>
        [JsonProperty("hairVariation")]
        public int HairVariation { get; set; }

        /// <summary>
        /// Gets or sets the hair color.
        /// </summary>
        [JsonProperty("hairColor")]
        public int HairColor { get; set; }

        /// <summary>
        /// Gets or sets the feature variation.
        /// </summary>
        [JsonProperty("featureVariation")]
        public int FeatureVariation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show the helm.
        /// </summary>
        [JsonProperty("showHelm")]
        public bool ShowHelm { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show the cloak.
        /// </summary>
        [JsonProperty("showCloak")]
        public bool ShowCloak { get; set; }

        /// <summary>
        /// Gets or sets the custom display options.
        /// </summary>
        [JsonProperty("customDisplayOptions")]
        public IList<int> CustomDisplayOptions { get; set; }
    }
}
