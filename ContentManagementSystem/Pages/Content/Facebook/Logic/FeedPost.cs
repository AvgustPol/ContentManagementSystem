using Newtonsoft.Json;

namespace ContentManagementSystem.Pages.Content.Facebook.Logic
{
    public class FeedPost
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Content { get; set; }

        [JsonProperty("full_picture")]
        public string Picture { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }
}