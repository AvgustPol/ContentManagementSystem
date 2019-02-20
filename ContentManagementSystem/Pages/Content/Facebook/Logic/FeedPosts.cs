using Newtonsoft.Json;
using System.Collections.Generic;

namespace ContentManagementSystem.Pages.Content.Facebook.Logic
{
    public class FeedPosts
    {
        [JsonProperty("data")]
        public IEnumerable<FeedPost> Posts { get; set; }
    }
}
