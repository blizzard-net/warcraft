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
        public int FaceVariation { get; set; }

        /// <summary>
        /// Gets the skin color index.
        /// </summary>
        [JsonPropertyName("skin_color")]
        public int SkinColor { get; set; }

        /// <summary>
        /// Gets the hair variation index.
        /// </summary>
        [JsonPropertyName("hair_variation")]
        public int HairVariation { get; set; }

        /// <summary>
        /// Gets the hair color index.
        /// </summary>
        [JsonPropertyName("hair_color")]
        public int HairColor { get; set; }

        /// <summary>
        /// Gets the feature variation index.
        /// </summary>
        [JsonPropertyName("feature_variation")]
        public int FeatureVariation { get; set; }

        /// <summary>
        /// Gets custom display options for the appearance.
        /// </summary>
        [JsonPropertyName("custom_display_options")]
        public int[] CustomDisplayOptions { get; set; }
    }
}
