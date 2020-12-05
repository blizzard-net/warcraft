using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public interface ITechTalentApi
    {
        Task<RequestResult<TechTalentTreesIndex>> GetTechTalentTreeIndexAsync(string @namespace);

        Task<RequestResult<TechTalentTreesIndex>> GetTechTalentTreeIndexAsync(string @namespace, Region region,
            Locale locale);
    }
}
