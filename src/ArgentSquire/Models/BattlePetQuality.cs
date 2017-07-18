using System.ComponentModel.DataAnnotations;

namespace ArgentSquire
{
    /// <summary>
    /// Battle pet quality.
    /// </summary>
    public enum BattlePetQuality
    {
        /// <summary>
        /// Poor.
        /// </summary>
        [Display(Name = "Poor")]
        Poor = 0,

        /// <summary>
        /// Common.
        /// </summary>
        [Display(Name = "Common")]
        Common = 1,

        /// <summary>
        /// Uncommon.
        /// </summary>
        [Display(Name = "Uncommon")]
        Uncommon = 2,

        /// <summary>
        /// Rare.
        /// </summary>
        [Display(Name = "Rare")]
        Rare = 3,

        /// <summary>
        /// Epic.
        /// </summary>
        [Display(Name = "Epic")]
        Epic = 4,

        /// <summary>
        /// Legendary.
        /// </summary>
        [Display(Name = "Legendary")]
        Legendary = 5
    }
}
