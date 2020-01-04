using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.Community
{
    /// <summary>
    /// Weapon info.
    /// </summary>
    public class WeaponInfo
    {
        /// <summary>
        /// Gets or sets the damage.
        /// </summary>
        [JsonProperty("damage")]
        public Damage Damage { get; set; }

        /// <summary>
        /// Gets or sets the weapon speed.
        /// </summary>
        [JsonProperty("weaponSpeed")]
        public double WeaponSpeed { get; set; }

        /// <summary>
        /// Gets or sets the damage per second (DPS).
        /// </summary>
        [JsonProperty("dps")]
        public double Dps { get; set; }
    }
}
