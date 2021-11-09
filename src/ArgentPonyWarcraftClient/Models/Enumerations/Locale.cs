namespace ArgentPonyWarcraftClient;

/// <summary>
///     Represents the different locales supported by the Blizzard API.
/// </summary>
public enum Locale
{
    /// <summary>
    ///     English (United States of America)
    /// </summary>
    [LocaleRegion(Region.US)]
    en_US,

    /// <summary>
    ///     Spanish (Mexico)
    /// </summary>
    [LocaleRegion(Region.US)]
    es_MX,

    /// <summary>
    ///     Portuguese (Brazil)
    /// </summary>
    [LocaleRegion(Region.US)]
    pt_BR,

    /// <summary>
    ///     English (United Kingdom)
    /// </summary>
    [LocaleRegion(Region.Europe)]
    en_GB,

    /// <summary>
    ///     Spanish (Spain)
    /// </summary>
    [LocaleRegion(Region.Europe)]
    es_ES,

    /// <summary>
    ///     French (France)
    /// </summary>
    [LocaleRegion(Region.Europe)]
    fr_FR,

    /// <summary>
    ///     Russian (Russian Federation)
    /// </summary>
    [LocaleRegion(Region.Europe)]
    ru_RU,

    /// <summary>
    ///     German (Germany)
    /// </summary>
    [LocaleRegion(Region.Europe)]
    de_DE,

    /// <summary>
    ///     Portuguese (Portugal)
    /// </summary>
    [LocaleRegion(Region.Europe)]
    pt_PT,

    /// <summary>
    ///     Italian (Italy)
    /// </summary>
    [LocaleRegion(Region.Europe)]
    it_IT,

    /// <summary>
    ///     Korean (Korea)
    /// </summary>
    [LocaleRegion(Region.Korea)]
    ko_KR,

    /// <summary>
    ///     Chinese (Taiwan)
    /// </summary>
    [LocaleRegion(Region.Taiwan)]
    zh_TW,

    /// <summary>
    ///     Chinese (China)
    /// </summary>
    [LocaleRegion(Region.China)]
    zh_CN
}
