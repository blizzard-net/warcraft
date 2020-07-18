using System.Reflection;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Extensions to the <see cref="Locale"/> enum.
    /// </summary>
    internal static class LocaleExtensions
    {
        /// <summary>
        /// Gets the <see cref="Region"/> value that is allowed
        /// for the specific <see cref="Locale"/> based on the
        /// <see cref="LocaleRegion"/> attribute.
        /// </summary>
        /// <param name="locale">The <see cref="Locale"/> instance.</param>
        /// <returns>The <see cref="Region"/> value for the specified <see cref="Locale"/>.</returns>
        internal static Region GetRegionForLocale(this Locale locale)
        {
            var fieldInfo = locale.GetType().GetRuntimeField(locale.ToString());
            var localeRegionAttribute = fieldInfo.GetCustomAttribute<LocaleRegion>();

            return localeRegionAttribute.Region;
        }
    }
}
