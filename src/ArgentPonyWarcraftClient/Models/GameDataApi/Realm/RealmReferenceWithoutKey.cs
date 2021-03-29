﻿using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a realm.
    /// </summary>
    public record RealmReferenceWithoutKey
    {
        /// <summary>
        /// Gets the name of the realm.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// Gets the ID of the realm.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; init; }

        /// <summary>
        /// Gets a slug for the realm.
        /// </summary>
        [JsonPropertyName("slug")]
        public string Slug { get; init; }
    }
}
