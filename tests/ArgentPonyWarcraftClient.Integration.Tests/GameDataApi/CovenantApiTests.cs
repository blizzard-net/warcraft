using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class CovenantApiTests
    {
        [ResilientFact]
        public Task When_Getting_A_Conduit_By_Id_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ICovenantApi client = ClientFactory.BuildClient();

            Assert.True(false, "TODO");

            return Task.CompletedTask;
        }

        [ResilientFact]
        public Task When_Getting_A_Covenant_By_Id_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ICovenantApi client = ClientFactory.BuildClient();

            Assert.True(false, "TODO");

            return Task.CompletedTask;
        }

        [ResilientFact]
        public Task When_Getting_A_Soulbind_By_Id_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ICovenantApi client = ClientFactory.BuildClient();

            Assert.True(false, "TODO");

            return Task.CompletedTask;
        }

        [ResilientFact]
        public Task When_Getting_Conduits_Index_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ICovenantApi client = ClientFactory.BuildClient();

            Assert.True(false, "TODO");

            return Task.CompletedTask;
        }

        [ResilientFact]
        public Task When_Getting_Covenant_Media_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ICovenantApi client = ClientFactory.BuildClient();

            Assert.True(false, "TODO");

            return Task.CompletedTask;
        }

        [ResilientFact]
        public Task When_Getting_Covenants_Index_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ICovenantApi client = ClientFactory.BuildClient();

            Assert.True(false, "TODO");

            return Task.CompletedTask;
        }

        [ResilientFact]
        public Task When_Getting_Soulbinds_Index_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ICovenantApi client = ClientFactory.BuildClient();

            Assert.True(false, "TODO");

            return Task.CompletedTask;
        }
    }
}
