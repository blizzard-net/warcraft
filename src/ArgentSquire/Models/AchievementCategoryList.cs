using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// An achievement category list.
    /// </summary>
    public class AchievementCategoryList
    {
        /// <summary>
        /// Gets or sets the achievement categories.
        /// </summary>
        [JsonProperty("achievements")]
        public IList<AchievementCategory> AchievementCategories { get; set; }
    }
}
