using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Settings related to a character's appearance.
    /// </summary>
    public record Appearance
    {
        /// <summary>
        /// Gets the face variation index.
        /// </summary>
        [JsonPropertyName("face_variation")]
        public int FaceVariation { get; }

        /// <summary>
        /// Gets the skin color index.
        /// </summary>
        [JsonPropertyName("skin_color")]
        public int SkinColor { get; }

        /// <summary>
        /// Gets the hair variation index.
        /// </summary>
        [JsonPropertyName("hair_variation")]
        public int HairVariation { get; }

        /// <summary>
        /// Gets the hair color index.
        /// </summary>
        [JsonPropertyName("hair_color")]
        public int HairColor { get; }

        /// <summary>
        /// Gets the feature variation index.
        /// </summary>
        [JsonPropertyName("feature_variation")]
        public int FeatureVariation { get; }

        /// <summary>
        /// Gets custom display options for the appearance.
        /// </summary>
        [JsonPropertyName("custom_display_options")]
        public int[] CustomDisplayOptions { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Appearance"/> class.
        /// </summary>
        /// <param name="faceVariation">The face variation index.</param>
        /// <param name="skinColor">The skin color index.</param>
        /// <param name="hairVariation">The hair variation index.</param>
        /// <param name="hairColor">The hair color index.</param>
        /// <param name="featureVariation">The feature variation index.</param>
        /// <param name="customDisplayOptions">Custom display options for the appearance.</param>
        [JsonConstructor]
        public Appearance(int faceVariation, int skinColor, int hairVariation, int hairColor, int featureVariation, int[] customDisplayOptions)
        {
            FaceVariation = faceVariation;
            SkinColor = skinColor;
            HairVariation = hairVariation;
            HairColor = hairColor;
            FeatureVariation = featureVariation;
            CustomDisplayOptions = customDisplayOptions;
        }
    }
}
