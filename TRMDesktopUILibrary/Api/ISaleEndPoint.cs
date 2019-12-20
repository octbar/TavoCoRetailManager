using System.Threading.Tasks;
using TRMDesktopUILibrary.Models;

namespace TRMDesktopUILibrary.Api
{
    public interface ISaleEndPoint
    {
        Task PostSale(SaleModel sale);
    }
}