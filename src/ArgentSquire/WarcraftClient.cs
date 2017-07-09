using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// A client for the World of Warcraft Community APIs.
    /// </summary>
    public class WarcraftClient
    {
        /// <summary>
        /// The API key.
        /// </summary>
        private readonly string _apiKey;

        /// <summary>
        /// The region.
        /// </summary>
        private readonly Region _region;

        /// <summary>
        /// The locale.
        /// </summary>
        private readonly string _locale;

        /// <summary>
        /// Initializes a new instance of the <see cref="WarcraftClient"/> class.
        /// </summary>
        /// <remarks>
        /// Defaults the region to US and the locale to "en_US".
        /// </remarks>
        /// <param name="apiKey">The API key.</param>
        public WarcraftClient(string apiKey)
            : this(apiKey, Region.US, "en_US")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WarcraftClient"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        public WarcraftClient(string apiKey, Region region, string locale)
        {
            _apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
            _region = region;
            _locale = locale;
        }

        /// <summary>
        /// Get the specified achievement.
        /// </summary>
        /// <param name="id">The achievement ID.</param>
        /// <returns>
        /// The specified achievement.
        /// </returns>
        public async Task<Achievement> GetAchievementAsync(int id)
        {
            return await GetAchievementAsync(id, _region, _locale);
        }

        /// <summary>
        /// Get the specified achievement.
        /// </summary>
        /// <param name="id">The achievement ID.</param>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        /// <returns>
        /// The specified achievement.
        /// </returns>
        public async Task<Achievement> GetAchievementAsync(int id, Region region, string locale)
        {
            string host = GetHost(region);
            return await Get<Achievement>($"{host}/wow/achievement/{id}?locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        /// Get the specified boss.
        /// </summary>
        /// <remarks>
        /// A "boss" in this context should be considered a boss encounter, which may include more than one NPC.
        /// </remarks>
        /// <param name="id">The boss ID.</param>
        /// <returns>
        /// The specified boss.
        /// </returns>
        public async Task<Boss> GetBossAsync(int id)
        {
            return await GetBossAsync(id, _region, _locale);
        }

        /// <summary>
        /// Get the specified boss.
        /// </summary>
        /// <remarks>
        /// A "boss" in this context should be considered a boss encounter, which may include more than one NPC.
        /// </remarks>
        /// <param name="id">The boss ID.</param>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        /// <returns>
        /// The specified boss.
        /// </returns>
        public async Task<Boss> GetBossAsync(int id, Region region, string locale)
        {
            string host = GetHost(region);
            return await Get<Boss>($"{host}/wow/boss/{id}?locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        /// Get a list of all supported bosses.
        /// </summary>
        /// <remarks>
        /// A "boss" in this context should be considered a boss encounter, which may include more than one NPC.
        /// </remarks>
        /// <returns>
        /// A list of all supported bosses.
        /// </returns>
        public async Task<List<Boss>> GetBossesAsync()
        {
            return await GetBossesAsync(_region, _locale);
        }

        /// <summary>
        /// Get a list of all supported bosses.
        /// </summary>
        /// <remarks>
        /// A "boss" in this context should be considered a boss encounter, which may include more than one NPC.
        /// </remarks>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        /// <returns>
        /// A list of all supported bosses.
        /// </returns>
        public async Task<List<Boss>> GetBossesAsync(Region region, string locale)
        {
            string host = GetHost(region);
            BossList bossList = await Get<BossList>($"{host}/wow/boss/?locale={locale}&apikey={_apiKey}");
            return bossList.Bosses;
        }

        /// <summary>
        /// Retrieve an item of type <typeparamref name="T"/> from the Blizzard Community API.
        /// </summary>
        /// <typeparam name="T">
        /// The return type.
        /// </typeparam>
        /// <param name="requestUri">
        /// The URI the request is sent to.
        /// </param>
        /// <returns>
        /// The JSON response, deserialized to an object of type <typeparamref name="T"/>.
        /// </returns>
        private async Task<T> Get<T>(string requestUri)
        {
            // Retrieve the response.  Throw an error if we had a problem.
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(requestUri);
            response.EnsureSuccessStatusCode();

            // Deserialize an object of type T from the JSON string.
            string json = await response.Content.ReadAsStringAsync();
            T item = JsonConvert.DeserializeObject<T>(json, new JsonSerializerSettings
            {
                MissingMemberHandling = MissingMemberHandling.Error
            });

            return item;
        }

        /// <summary>
        /// Get the host for the specified region.
        /// </summary>
        /// <param name="region">The region.</param>
        /// <returns>
        /// The host for the specified region.
        /// </returns>
        private static string GetHost(Region region)
        {
            switch (region)
            {
                case Region.China:
                    return "https://www.battlenet.com.cn";
                case Region.Europe:
                    return "https://eu.api.battle.net";
                case Region.Korea:
                    return "https://kr.api.battle.net";
                case Region.Taiwan:
                    return "https://tw.api.battle.net";
                case Region.US:
                default:
                    return "https://us.api.battle.net";
            }
        }
    }
}
