using System.Collections.Generic;
using System.Threading.Tasks;
using TRMDesktopUILibrary.Models;

namespace TRMDesktopUILibrary.Api
{
    public interface IUserEndPoint
    {
        Task<List<UserModel>> GetAll();
    }
}