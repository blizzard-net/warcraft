using System.Reflection;

namespace ArgentPonyWarcraftClient;

/// <summary>
/// Extensions to the <see cref="Locale"/> enum.
/// </summary>
public static class LocaleExtensions
{
    /// <summary>
    /// Gets the <see cref="Region"/> value that is allowed
    /// for the specific <see cref="Locale"/> based on the
    /// <see cref="LocaleRegion"/> attribute.
    /// </summary>
    /// <param name="locale">The <see cref="Locale"/> instance.</param>
    /// <returns>The <see cref="Region"/> value for the specified <see cref="Locale"/>.</returns>
    public static Region GetRegionForLocale(this Locale locale)
    {
        FieldInfo fieldInfo = locale.GetType().GetRuntimeField(locale.ToString());
        LocaleRegion localeRegionAttribute = fieldInfo.GetCustomAttribute<LocaleRegion>();

        return localeRegionAttribute.Region;
    }

    /// <summary>
    /// Determines whether or not the <see cref="Locale"/> instance is supported in
    /// the specified <paramref name="region"/>.
    /// </summary>
    /// <param name="locale">The <see cref="Locale"/> instance.</param>
    /// <param name="region">The <see cref="Region"/> to check.</param>
    /// <returns>
    /// True if the <see cref="Locale"/> is supported in the <paramref name="region"/>,
    /// otherwise false.
    /// </returns>
    public static bool IsSupportedInRegion(this Locale locale, Region region)
    {
        return locale.GetRegionForLocale() == region;
    }
}
