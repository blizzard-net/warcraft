namespace ArgentPonyWarcraftClient;

/// <summary>
///     Used to set a valid region for a locale.
/// </summary>
public class LocaleRegion : Attribute
{
    /// <summary>
    ///     Sets a valid region for a locale.
    /// </summary>
    /// <param name="region">The selected region.</param>
    public LocaleRegion(Region region)
    {
        Region = region;
    }

    /// <summary>
    ///     Sets the region of the region.
    /// </summary>
    public Region Region { get; }
}
