using AutoMapper;
using System.Threading.Tasks;

namespace ContentManagementSystem.Pages.Content.Facebook.Logic
{
    public class FacebookService : IFacebookService
    {
        private readonly FacebookSettings _facebookSettings;
        private readonly IFacebookClient _facebookClient;

        public FacebookService(FacebookSettings facebookSettings, IFacebookClient facebookClient)
        {
            _facebookSettings = facebookSettings;
            _facebookClient = facebookClient;
        }

        public async Task<FeedPostsDto> GetPostsAsync(int count)
        {
            if (count > 100)
            {
                count = 100;
            }

            var posts = await _facebookClient.GetAsync<FeedPosts>(_facebookSettings.AccessToken, "KNKredek/posts",
                $"fields=full_picture,link,message&limit={count}").ConfigureAwait(false);

            if (posts == null)
            {
                return null;
            }

            var result = Mapper.Map<FeedPostsDto>(posts);

            return result;
        }
    }
}