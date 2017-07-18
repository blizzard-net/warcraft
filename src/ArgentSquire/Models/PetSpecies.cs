using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// A pet species.
    /// </summary>
    public class PetSpecies
    {
        /// <summary>
        /// Gets or sets the species ID.
        /// </summary>
        [JsonProperty("speciesId")]
        public int SpeciesId { get; set; }

        /// <summary>
        /// Gets or sets the pet type ID.
        /// </summary>
        [JsonProperty("petTypeId")]
        public int PetTypeId { get; set; }

        /// <summary>
        /// Gets or sets the creature ID.
        /// </summary>
        [JsonProperty("creatureId")]
        public int CreatureId { get; set; }

        /// <summary>
        /// Gets or sets the species name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the pet is a battle pet.
        /// </summary>
        [JsonProperty("canBattle")]
        public bool CanBattle { get; set; }

        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets the abilities.
        /// </summary>
        [JsonProperty("abilities")]
        public IList<PetSpeciesAbility> Abilities { get; set; }
    }
}
