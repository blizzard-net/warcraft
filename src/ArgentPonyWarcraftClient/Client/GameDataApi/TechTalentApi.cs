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
        public Task<RequestResult<TechTalentTreesIndex>> GetTechTalentTreeIndexAsync(string @namespace, Region region, Locale locale) => throw new NotImplementedException();
    }
}
