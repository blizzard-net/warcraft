using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Settings related to a character's appearance.
    /// </summary>
    public class Appearance
    {
        /// <summary>
        /// Gets the face variation index.
        /// </summary>
        [JsonProperty("face_variation")]
        public long FaceVariation { get; set; }

        /// <summary>
        /// Gets the skin color index.
        /// </summary>
        [JsonProperty("skin_color")]
        public long SkinColor { get; set; }

        /// <summary>
        /// Gets the hair variation index.
        /// </summary>
        [JsonProperty("hair_variation")]
        public long HairVariation { get; set; }

        /// <summary>
        /// Gets the hair color index.
        /// </summary>
        [JsonProperty("hair_color")]
        public long HairColor { get; set; }

        /// <summary>
        /// Gets the feature variation index.
        /// </summary>
        [JsonProperty("feature_variation")]
        public long FeatureVariation { get; set; }

        /// <summary>
        /// Gets custom display options for the appearance.
        /// </summary>
        [JsonProperty("custom_display_options")]
        public long[] CustomDisplayOptions { get; set; }
    }
}
