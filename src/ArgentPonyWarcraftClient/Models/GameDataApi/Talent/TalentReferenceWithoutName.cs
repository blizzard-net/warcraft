﻿using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a talent.
    /// </summary>
    public class TalentReferenceWithoutName
    {
        /// <summary>
        /// Gets the key for the talent.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the ID of the talent.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
