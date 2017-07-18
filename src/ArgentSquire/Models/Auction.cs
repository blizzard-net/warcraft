using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// An auction.
    /// </summary>
    public class Auction
    {
        /// <summary>
        /// Gets or sets the auction ID.
        /// </summary>
        [JsonProperty("auc")]
        public int AuctionId { get; set; }

        /// <summary>
        /// Gets or sets the item ID.
        /// </summary>
        [JsonProperty("item")]
        public int ItemId { get; set; }

        /// <summary>
        /// Gets or sets the owner's name.
        /// </summary>
        [JsonProperty("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// Gets or sets the owner's realm name.
        /// </summary>
        [JsonProperty("ownerRealm")]
        public string OwnerRealm { get; set; }

        /// <summary>
        /// Gets or sets the current bid.
        /// </summary>
        [JsonProperty("bid")]
        public long Bid { get; set; }

        /// <summary>
        /// Gets or sets the buyout.
        /// </summary>
        [JsonProperty("buyout")]
        public long Buyout { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the time left.
        /// </summary>
        [JsonProperty("timeLeft")]
        public string TimeLeft { get; set; }

        /// <summary>
        /// Gets or sets the rand.
        /// </summary>
        [JsonProperty("rand")]
        public int Rand { get; set; }

        /// <summary>
        /// Gets or sets the seed.
        /// </summary>
        [JsonProperty("seed")]
        public long Seed { get; set; }

        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        [JsonProperty("context")]
        public int Context { get; set; }

        /// <summary>
        /// Gets or sets the bonus lists.
        /// </summary>
        [JsonProperty("bonusLists")]
        public IList<BonusList> BonusLists { get; set; }

        /// <summary>
        /// Gets or sets the modifiers.
        /// </summary>
        [JsonProperty("modifiers")]
        public IList<Modifier> Modifiers { get; set; }

        /// <summary>
        /// Gets or sets the pet species ID.
        /// </summary>
        [JsonProperty("petSpeciesId")]
        public int? PetSpeciesId { get; set; }

        /// <summary>
        /// Gets or sets the pet breed ID.
        /// </summary>
        [JsonProperty("petBreedId")]
        public int? PetBreedId { get; set; }

        /// <summary>
        /// Gets or sets the pet level.
        /// </summary>
        [JsonProperty("petLevel")]
        public int? PetLevel { get; set; }

        /// <summary>
        /// Gets or sets the battle pet quality.
        /// </summary>
        [JsonProperty("petQualityId")]
        public BattlePetQuality? PetQuality { get; set; }
    }
}
