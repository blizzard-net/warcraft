using System;
using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        public Task<RequestResult<CovenantsIndex>> GetCovenantsIndexAsync(string @namespace) => throw new NotImplementedException();

        public Task<RequestResult<CovenantsIndex>> GetCovenantsIndexAsync(string @namespace, Region region, Locale locale) => throw new NotImplementedException();
    }
}
