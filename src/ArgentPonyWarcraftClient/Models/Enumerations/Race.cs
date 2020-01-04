using System.ComponentModel.DataAnnotations;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Races.
    /// </summary>
    public enum Race
    {
        /// <summary>
        /// Human.
        /// </summary>
        [Display(Name = "Human")]
        Human = 1,

        /// <summary>
        /// Orc.
        /// </summary>
        [Display(Name = "Orc")]
        Orc = 2,

        /// <summary>
        /// Dwarf.
        /// </summary>
        [Display(Name = "Dwarf")]
        Dwarf = 3,

        /// <summary>
        /// Night Elf.
        /// </summary>
        [Display(Name = "Night Elf")]
        NightElf = 4,

        /// <summary>
        /// Undead.
        /// </summary>
        [Display(Name = "Undead")]
        Undead = 5,

        /// <summary>
        /// Tauren.
        /// </summary>
        [Display(Name = "Tauren")]
        Tauren = 6,

        /// <summary>
        /// Gnome.
        /// </summary>
        [Display(Name = "Gnome")]
        Gnome = 7,

        /// <summary>
        /// Troll.
        /// </summary>
        [Display(Name = "Troll")]
        Troll = 8,

        /// <summary>
        /// Goblin.
        /// </summary>
        [Display(Name = "Goblin")]
        Goblin = 9,

        /// <summary>
        /// Blood Elf.
        /// </summary>
        [Display(Name = "Blood Elf")]
        BloodElf = 10,

        /// <summary>
        /// Draenei.
        /// </summary>
        [Display(Name = "Draenei")]
        Draenei = 11,

        /// <summary>
        /// Worgen.
        /// </summary>
        [Display(Name = "Worgen")]
        Worgen = 22,

        /// <summary>
        /// Pandaren (Neutral).
        /// </summary>
        [Display(Name = "Pandaren (Neutral)")]
        PandarenNeutral = 24,

        /// <summary>
        /// Pandaren (Alliance).
        /// </summary>
        [Display(Name = "Pandaren (Alliance)")]
        PandarenAlliance = 25,

        /// <summary>
        /// Pandaren (Horde).
        /// </summary>
        [Display(Name = "Pandaren (Horde)")]
        PandarenHorde = 26,

        /// <summary>
        /// Nightborne Elf
        /// </summary>
        [Display(Name = "Nightborne Elf")]
        NightborneElf = 27,

        /// <summary>
        /// Highmountain Tauren
        /// </summary>
        [Display(Name = "Highmountain Tauren")]
        HighmountainTauren = 28,

        /// <summary>
        /// Void Elf
        /// </summary>
        [Display(Name = "Void Elf")]
        VoidElf = 29,

        /// <summary>
        /// Lightforged Draenei
        /// </summary>
        [Display(Name = "Lightforged Draenei")]
        LightforgedDraenei = 30
    }
}
