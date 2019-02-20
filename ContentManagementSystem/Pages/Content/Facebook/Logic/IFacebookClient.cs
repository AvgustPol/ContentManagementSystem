using System.Threading.Tasks;

namespace ContentManagementSystem.Pages.Content.Facebook.Logic
{
    public interface IFacebookClient : IService
    {
        Task<T> GetAsync<T>(string accessToken, string endpoint, string args = null);

        Task PostAsync(string accessToken, string endpoint, object data, string args = null);
    }
}