using System.ComponentModel.DataAnnotations;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Item quality.
    /// </summary>
    public enum ItemQuality
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
        Legendary = 5,

        /// <summary>
        /// Artifact.
        /// </summary>
        [Display(Name = "Artifact")]
        Artifact = 6,

        /// <summary>
        /// Heirloom.
        /// </summary>
        [Display(Name = "Heirloom")]
        Heirloom = 5
    }
}
