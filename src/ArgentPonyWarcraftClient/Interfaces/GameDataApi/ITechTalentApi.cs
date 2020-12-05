using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public interface ITechTalentApi
    {
        Task<RequestResult<TechTalentTreesIndex>> GetTechTalentTreeIndexAsync(string @namespace);

        Task<RequestResult<TechTalentTreesIndex>> GetTechTalentTreeIndexAsync(string @namespace, Region region, Locale locale);

        Task<RequestResult<TechTalentTree>> GetTechTalentTreeAsync(int techTalentTreeId, string @namespace);

        Task<RequestResult<TechTalentTree>> GetTechTalentTreeAsync(int techTalentTreeId, string @namespace, Region region, Locale locale);

        Task<RequestResult<TechTalentsIndex>> GetTechTalentsIndexAsync(string @namespace);

        Task<RequestResult<TechTalentsIndex>> GetTechTalentsIndexAsync(string @namespace, Region region, Locale locale);

        Task<RequestResult<TechTalent>> GetTechTalentAsync(int techTalentId, string @namespace);

        Task<RequestResult<TechTalent>> GetTechTalentAsync(int techTalentId, string @namespace, Region region, Locale locale);
    }
}
