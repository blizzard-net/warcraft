namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Game Data and Profile APIs.
/// </summary>
public interface IWarcraftClient :
    IGameDataApi,
    IProfileApi
{
}
