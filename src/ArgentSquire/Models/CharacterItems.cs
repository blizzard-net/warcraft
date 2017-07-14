using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ArgentSquire
{
    public class CharacterItems
    {
        [JsonProperty("averageItemLevel")]
        public int AverageItemLevel { get; set; }

        [JsonProperty("averageItemLevelEquipped")]
        public int AverageItemLevelEquipped { get; set; }

        [JsonProperty("head")]
        public CharacterItem Head { get; set; }

        [JsonProperty("neck")]
        public CharacterItem Neck { get; set; }

        [JsonProperty("shoulder")]
        public CharacterItem Shoulder { get; set; }

        [JsonProperty("back")]
        public CharacterItem Back { get; set; }

        [JsonProperty("chest")]
        public CharacterItem Chest { get; set; }

        [JsonProperty("shirt")]
        public CharacterItem Shirt { get; set; }

        [JsonProperty("tabard")]
        public CharacterItem Tabard { get; set; }

        [JsonProperty("wrist")]
        public CharacterItem Wrist { get; set; }

        [JsonProperty("hands")]
        public CharacterItem Hands { get; set; }

        [JsonProperty("waist")]
        public CharacterItem Waist { get; set; }

        [JsonProperty("legs")]
        public CharacterItem Legs { get; set; }

        [JsonProperty("feet")]
        public CharacterItem Feet { get; set; }

        [JsonProperty("finger1")]
        public CharacterItem Finger1 { get; set; }

        [JsonProperty("finger2")]
        public CharacterItem Finger2 { get; set; }

        [JsonProperty("trinket1")]
        public CharacterItem Trinket1 { get; set; }

        [JsonProperty("trinket2")]
        public CharacterItem Trinket2 { get; set; }

        [JsonProperty("mainHand")]
        public CharacterItem MainHand { get; set; }

        [JsonProperty("offHand")]
        public CharacterItem OffHand { get; set; }
    }
}
