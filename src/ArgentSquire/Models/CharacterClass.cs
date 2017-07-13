using System.ComponentModel.DataAnnotations;

namespace ArgentSquire
{
    /// <summary>
    /// Character classes.
    /// </summary>
    public enum CharacterClass
    {
        /// <summary>
        /// Warrior.
        /// </summary>
        [Display(Name = "Warrior")]
        Warrior = 1,

        /// <summary>
        /// Paladin.
        /// </summary>
        [Display(Name = "Paladin")]
        Paladin = 2,

        /// <summary>
        /// Hunter.
        /// </summary>
        [Display(Name = "Hunter")]
        Hunter = 3,

        /// <summary>
        /// Rogue.
        /// </summary>
        [Display(Name = "Rogue")]
        Rogue = 4,

        /// <summary>
        /// Priest.
        /// </summary>
        [Display(Name = "Priest")]
        Priest = 5,

        /// <summary>
        /// Death Knight.
        /// </summary>
        [Display(Name = "Death Knight")]
        DeathKnight = 6,

        /// <summary>
        /// Shaman.
        /// </summary>
        [Display(Name = "Shaman")]
        Shaman = 7,

        /// <summary>
        /// Mage.
        /// </summary>
        [Display(Name = "Mage")]
        Mage = 8,

        /// <summary>
        /// Warlock.
        /// </summary>
        [Display(Name = "Warlock")]
        Warlock = 9,

        /// <summary>
        /// Monk.
        /// </summary>
        [Display(Name = "Monk")]
        Monk = 10,

        /// <summary>
        /// Druid.
        /// </summary>
        [Display(Name = "Druid")]
        Druid = 11,

        /// <summary>
        /// Demon Hunter.
        /// </summary>
        [Display(Name = "Demon Hunter")]
        DemonHunter = 12
    }
}
