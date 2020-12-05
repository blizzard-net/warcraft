using System;
using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public Task<RequestResult<TechTalentTreesIndex>> GetTechTalentTreeIndexAsync(string @namespace) =>
            GetTechTalentTreeIndexAsync(@namespace, _region, _locale);

        /// <inheritdoc />
        public Task<RequestResult<TechTalentTreesIndex>> GetTechTalentTreeIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return GetAsync<TechTalentTreesIndex>($"{host}/data/wow/tech-talent-tree/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public Task<RequestResult<TechTalentTree>> GetTechTalentTreeAsync(int techTalentTreeId, string @namespace) => GetTechTalentTreeAsync(techTalentTreeId, @namespace, _region, _locale);

        /// <inheritdoc />
        public Task<RequestResult<TechTalentTree>> GetTechTalentTreeAsync(int techTalentTreeId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return GetAsync<TechTalentTree>($"{host}/data/wow/tech-talent-tree/{techTalentTreeId}?namespace={@namespace}&locale={locale}");
        }
    }
}
