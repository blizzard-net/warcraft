using System;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A World of Warcraft player character.
    /// </summary>
    public record CharacterProfileSummary
    {
        /// <summary>
        /// Gets links for the character.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the character.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the character.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the gender of the character.
        /// </summary>
        [JsonPropertyName("gender")]
        public EnumType Gender { get; }

        /// <summary>
        /// Gets the faction of the character (Alliance or Horde).
        /// </summary>
        [JsonPropertyName("faction")]
        public EnumType Faction { get; }

        /// <summary>
        /// Gets the race of the character.
        /// </summary>
        [JsonPropertyName("race")]
        public PlayableRaceReference Race { get; }

        /// <summary>
        /// Gets the class of the character.
        /// </summary>
        [JsonPropertyName("character_class")]
        public PlayableClassReference CharacterClass { get; }

        /// <summary>
        /// Gets the active spec for the character.
        /// </summary>
        [JsonPropertyName("active_spec")]
        public PlayableSpecializationReference ActiveSpec { get; }

        /// <summary>
        /// Gets a reference to the character's realm.
        /// </summary>
        [JsonPropertyName("realm")]
        public RealmReference Realm { get; }

        /// <summary>
        /// Gets a reference to the character's guild.
        /// </summary>
        [JsonPropertyName("guild")]
        public GuildReference Guild { get; }

        /// <summary>
        /// Gets the level of the character.
        /// </summary>
        [JsonPropertyName("level")]
        public int Level { get; }

        /// <summary>
        /// Gets the character's experience points.
        /// </summary>
        [JsonPropertyName("experience")]
        public int Experience { get; }

        /// <summary>
        /// Gets the number of achievement points the character has earned.
        /// </summary>
        [JsonPropertyName("achievement_points")]
        public int AchievementPoints { get; }

        /// <summary>
        /// Gets a link to the character's achievements.
        /// </summary>
        [JsonPropertyName("achievements")]
        public Self Achievements { get; }

        /// <summary>
        /// Gets a link to the character's titles.
        /// </summary>
        [JsonPropertyName("titles")]
        public Self Titles { get; }

        /// <summary>
        /// Gets a link to the character's PVP summary.
        /// </summary>
        [JsonPropertyName("pvp_summary")]
        public Self PvpSummary { get; }

        /// <summary>
        /// Gets a link to the character's encounters.
        /// </summary>
        [JsonPropertyName("encounters")]
        public Self Encounters { get; }

        /// <summary>
        /// Gets a link to the media for this character.
        /// </summary>
        [JsonPropertyName("media")]
        public Self Media { get; }

        /// <summary>
        /// Gets the last login timestamp for the character.
        /// </summary>
        [JsonPropertyName("last_login_timestamp")]
        public DateTimeOffset LastLoginTimestamp { get; }

        /// <summary>
        /// Gets the character's average item level.
        /// </summary>
        [JsonPropertyName("average_item_level")]
        public int AverageItemLevel { get; }

        /// <summary>
        /// Gets the character's equipped item level.
        /// </summary>
        [JsonPropertyName("equipped_item_level")]
        public int EquippedItemLevel { get; }

        /// <summary>
        /// Gets a link to the character's specializations.
        /// </summary>
        [JsonPropertyName("specializations")]
        public Self Specializations { get; }

        /// <summary>
        /// Gets a link to the character's statistics.
        /// </summary>
        [JsonPropertyName("statistics")]
        public Self Statistics { get; }

        /// <summary>
        /// Gets a link to the character's mythic keystone profile.
        /// </summary>
        [JsonPropertyName("mythic_keystone_profile")]
        public Self MythicKeystoneProfile { get; }

        /// <summary>
        /// Gets a link to the character's equipment.
        /// </summary>
        [JsonPropertyName("equipment")]
        public Self Equipment { get; }

        /// <summary>
        /// Gets a link to the character's appearance.
        /// </summary>
        [JsonPropertyName("appearance")]
        public Self Appearance { get; }

        /// <summary>
        /// Gets a link to the character's collections.
        /// </summary>
        [JsonPropertyName("collections")]
        public Self Collections { get; }

        /// <summary>
        /// Gets a reference to the active title for the character.
        /// </summary>
        [JsonPropertyName("active_title")]
        public TitleReferenceWithDisplayString ActiveTitle { get; }

        /// <summary>
        /// Gets a link to the character's reputations.
        /// </summary>
        [JsonPropertyName("reputations")]
        public Self Reputations { get; }

        /// <summary>
        /// Gets a link to the character's quests.
        /// </summary>
        [JsonPropertyName("quests")]
        public Self Quests { get; }

        /// <summary>
        /// Gets a link to the character's achievement statistics.
        /// </summary>
        [JsonPropertyName("achievements_statistics")]
        public Self AchievementsStatistics { get; }

        /// <summary>
        /// Gets a link to the character's professions.
        /// </summary>
        [JsonPropertyName("professions")]
        public Self Professions { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterProfileSummary"/> class.
        /// </summary>
        /// <param name="links">Links for the character.</param>
        /// <param name="id">The ID of the character.</param>
        /// <param name="name">The name of the character.</param>
        /// <param name="gender">The gender of the character.</param>
        /// <param name="faction">The faction of the character (Alliance or Horde).</param>
        /// <param name="race">The race of the character.</param>
        /// <param name="characterClass">The class of the character.</param>
        /// <param name="activeSpec">The active spec for the character.</param>
        /// <param name="realm">A reference to the character's realm.</param>
        /// <param name="guild">A reference to the character's guild.</param>
        /// <param name="level">The level of the character.</param>
        /// <param name="experience">The character's experience points.</param>
        /// <param name="achievementPoints">The number of achievement points the character has earned.</param>
        /// <param name="achievements">A link to the character's achievements.</param>
        /// <param name="titles">A link to the character's titles.</param>
        /// <param name="pvpSummary">A link to the character's PVP summary.</param>
        /// <param name="encounters">A link to the character's encounters.</param>
        /// <param name="media">A link to the media for this character.</param>
        /// <param name="lastLoginTimestamp">The last login timestamp for the character.</param>
        /// <param name="averageItemLevel">The character's average item level.</param>
        /// <param name="equippedItemLevel">The character's equipped item level.</param>
        /// <param name="specializations">A link to the character's specializations.</param>
        /// <param name="statistics">A link to the character's statistics.</param>
        /// <param name="mythicKeystoneProfile">A link to the character's mythic keystone profile.</param>
        /// <param name="equipment">A link to the character's equipment.</param>
        /// <param name="appearance">A link to the character's appearance.</param>
        /// <param name="collections">A link to the character's collections.</param>
        /// <param name="activeTitle">A reference to the active title for the character.</param>
        /// <param name="reputations">A link to the character's reputations.</param>
        /// <param name="quests">A link to the character's quests.</param>
        /// <param name="achievementsStatistics">A link to the character's achievement statistics.</param>
        /// <param name="professions">A link to the character's professions.</param>
        [JsonConstructor]
        public CharacterProfileSummary(Links links, int id, string name, EnumType gender, EnumType faction, PlayableRaceReference race, PlayableClassReference characterClass, PlayableSpecializationReference activeSpec, RealmReference realm, GuildReference guild, int level, int experience, int achievementPoints, Self achievements, Self titles, Self pvpSummary, Self encounters, Self media, DateTimeOffset lastLoginTimestamp, int averageItemLevel, int equippedItemLevel, Self specializations, Self statistics, Self mythicKeystoneProfile, Self equipment, Self appearance, Self collections, TitleReferenceWithDisplayString activeTitle, Self reputations, Self quests, Self achievementsStatistics, Self professions)
        {
            Links = links;
            Id = id;
            Name = name;
            Gender = gender;
            Faction = faction;
            Race = race;
            CharacterClass = characterClass;
            ActiveSpec = activeSpec;
            Realm = realm;
            Guild = guild;
            Level = level;
            Experience = experience;
            AchievementPoints = achievementPoints;
            Achievements = achievements;
            Titles = titles;
            PvpSummary = pvpSummary;
            Encounters = encounters;
            Media = media;
            LastLoginTimestamp = lastLoginTimestamp;
            AverageItemLevel = averageItemLevel;
            EquippedItemLevel = equippedItemLevel;
            Specializations = specializations;
            Statistics = statistics;
            MythicKeystoneProfile = mythicKeystoneProfile;
            Equipment = equipment;
            Appearance = appearance;
            Collections = collections;
            ActiveTitle = activeTitle;
            Reputations = reputations;
            Quests = quests;
            AchievementsStatistics = achievementsStatistics;
            Professions = professions;
        }
    }
}
