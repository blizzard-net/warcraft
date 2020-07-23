using System;

namespace ArgentPonyWarcraftClient.Integration.Tests.TestUtilities
{
    /// <summary>
    /// A service that retrieves the cliend ID and secret from environment variables or a file.
    /// </summary>
    internal static class ClientCredentialsSource
    {
        public static ClientCredentials GetCredentials()
        {
            ClientCredentials credentials = GetCredentialsFromEnvironment() ?? GetHardCodedCredentialsForLocal();

            if (credentials == null)
            {
                throw new NoCredentialsException("No credentials were configured in BLIZZARD_CLIENT_ID and BLIZZARD_CLIENT_SECRET environment variables or hard-coded in the ClientCredentialsSource.");
            }

            return credentials;
        }

        /// <summary>
        /// Retrieve credentials from BLIZZARD_CLIENT_ID and BLIZZARD_CLIENT_SECRET environment variables.
        /// </summary>
        /// <remarks>
        /// These environment variables are configured on the CircleCI server and used for CI builds.
        /// </remarks>
        /// <returns>
        /// The credentials.
        /// </returns>
        private static ClientCredentials GetCredentialsFromEnvironment()
        {
            string clientId = Environment.GetEnvironmentVariable("BLIZZARD_CLIENT_ID");
            string clientSecret = Environment.GetEnvironmentVariable("BLIZZARD_CLIENT_SECRET");

            if (string.IsNullOrWhiteSpace(clientId) || string.IsNullOrWhiteSpace(clientSecret))
            {
                return null;
            }

            var credentials = new ClientCredentials
            {
                ClientId = clientId,
                ClientSecret = clientSecret
            };

            return credentials;
        }

        /// <summary>
        /// Retrieve credentials from a local file.
        /// </summary>
        /// <remarks>
        /// Retrieving credentials from a local file is intended for local development scenarios.
        /// </remarks>
        /// <returns>
        /// The credentials.
        /// </returns>
        private static ClientCredentials GetHardCodedCredentialsForLocal()
        {
            // Add your client ID and client secret here to enable integration tests, but don't commit the change!
            string clientId = "";
            string clientSecret = "";

            if (string.IsNullOrWhiteSpace(clientId) || string.IsNullOrWhiteSpace(clientSecret))
            {
                return null;
            }

            var credentials = new ClientCredentials
            {
                ClientId = clientId,
                ClientSecret = clientSecret
            };

            return credentials;
        }
    }
}
