using System.Threading.Tasks;

namespace ContentManagementSystem.Pages.Content.Facebook.Logic
{
    public interface IFacebookService : IService
    {
        Task<FeedPostsDto> GetPostsAsync(int count);
    }
}