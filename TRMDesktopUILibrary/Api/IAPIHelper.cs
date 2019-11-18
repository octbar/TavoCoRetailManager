using System.Net.Http;
using System.Threading.Tasks;
using TRMDesktopUI.Models;

namespace TRMDesktopUILibrary.Api
{
    public interface IAPIHelper
    {
        HttpClient ApiClient { get; }
        Task<AuthenticatedUser> Authenticate(string userName, string password);
        Task GetLoggedUserInfo(string token);
    }
}