using System.Text.Json.Serialization;

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
        [JsonPropertyName("face_variation")]
        public long FaceVariation { get; set; }

        /// <summary>
        /// Gets the skin color index.
        /// </summary>
        [JsonPropertyName("skin_color")]
        public long SkinColor { get; set; }

        /// <summary>
        /// Gets the hair variation index.
        /// </summary>
        [JsonPropertyName("hair_variation")]
        public long HairVariation { get; set; }

        /// <summary>
        /// Gets the hair color index.
        /// </summary>
        [JsonPropertyName("hair_color")]
        public long HairColor { get; set; }

        /// <summary>
        /// Gets the feature variation index.
        /// </summary>
        [JsonPropertyName("feature_variation")]
        public long FeatureVariation { get; set; }

        /// <summary>
        /// Gets custom display options for the appearance.
        /// </summary>
        [JsonPropertyName("custom_display_options")]
        public long[] CustomDisplayOptions { get; set; }
    }
}
