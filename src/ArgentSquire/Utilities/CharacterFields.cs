using System;
using System.ComponentModel.DataAnnotations;

namespace ArgentSquire
{
    /// <summary>
    /// Optional fields to include with character information.
    /// </summary>
    [Flags]
    public enum CharacterFields
    {
        /// <summary>
        /// None.
        /// </summary>
        [Display(Name = "None")]
        None = 0,

        /// <summary>
        /// Achievements.
        /// </summary>
        [Display(Name = "Achievements")]
        Achievements = 1,

        /// <summary>
        /// Appearance.
        /// </summary>
        [Display(Name = "Appearance")]
        Appearance = 2,

        /// <summary>
        /// Feed.
        /// </summary>
        [Display(Name = "Feed")]
        Feed = 4,

        /// <summary>
        /// Guild.
        /// </summary>
        [Display(Name = "Guild")]
        Guild = 8,

        /// <summary>
        /// Hunter pets.
        /// </summary>
        [Display(Name = "Hunter Pets")]
        HunterPets = 16,

        /// <summary>
        /// Items.
        /// </summary>
        [Display(Name = "Items")]
        Items = 32,

        /// <summary>
        /// Mounts.
        /// </summary>
        [Display(Name = "Mounts")]
        Mounts = 64,

        /// <summary>
        /// Pets.
        /// </summary>
        [Display(Name = "Pets")]
        Pets = 128,

        /// <summary>
        /// Pet slots.
        /// </summary>
        [Display(Name = "Pet Slots")]
        PetSlots = 256,

        /// <summary>
        /// Professions.
        /// </summary>
        [Display(Name = "Professions")]
        Professions = 512,

        /// <summary>
        /// Progression.
        /// </summary>
        [Display(Name = "Progression")]
        Progression = 1024,

        /// <summary>
        /// PVP.
        /// </summary>
        [Display(Name = "PVP")]
        Pvp = 2048,

        /// <summary>
        /// Quests.
        /// </summary>
        [Display(Name = "Quests")]
        Quests = 4096,

        /// <summary>
        /// Reputation.
        /// </summary>
        [Display(Name = "Reputation")]
        Reputation = 8192,

        /// <summary>
        /// Statistics.
        /// </summary>
        [Display(Name = "Statistics")]
        Statistics = 16384,

        /// <summary>
        /// Stats.
        /// </summary>
        [Display(Name = "Stats")]
        Stats = 32768,

        /// <summary>
        /// Talents.
        /// </summary>
        [Display(Name = "Talents")]
        Talents = 65536,

        /// <summary>
        /// Titles.
        /// </summary>
        [Display(Name = "Titles")]
        Titles = 131072,

        /// <summary>
        /// Audit.
        /// </summary>
        [Display(Name = "Audit")]
        Audit = 262144,

        /// <summary>
        /// All.
        /// </summary>
        [Display(Name = "All")]
        All = 524287
    }
}
