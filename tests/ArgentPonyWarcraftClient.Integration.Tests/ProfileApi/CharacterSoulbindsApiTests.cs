using System.Threading.Tasks;
using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.ProfileApi;

public class CharacterSoulbindsApiTests
{
    [ResilientFact]
    public async Task GetCharacterSoulbindsAsync_Gets_CharacterSoulbinds()
    {
        ICharacterSoulbindsApi warcraftClient = ClientFactory.BuildClient();
        RequestResult<CharacterSoulbinds> result = await warcraftClient.GetCharacterSoulbindsAsync("ravencrest", "drizzy", "profile-us");
        Assert.NotNull(result.Value);
    }
}
