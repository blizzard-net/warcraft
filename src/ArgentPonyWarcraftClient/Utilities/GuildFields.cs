using System;
using System.ComponentModel.DataAnnotations;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    ///     Optional fields to include with guild information.
    /// </summary>
    [Flags]
    public enum GuildFields
    {
        /// <summary>
        ///     None.
        /// </summary>
        [Display(Name = "None")]
        None = 0,

        /// <summary>
        ///     Members.
        /// </summary>
        [Display(Name = "Members")]
        Members = 1,

        /// <summary>
        ///     Achievements.
        /// </summary>
        [Display(Name = "Achievements")]
        Achievements = 2,

        /// <summary>
        ///     Challenge.
        /// </summary>
        [Display(Name = "Challenge")]
        Challenge = 8,

        /// <summary>
        ///     All.
        /// </summary>
        [Display(Name = "All")]
        All = 11
    }
}