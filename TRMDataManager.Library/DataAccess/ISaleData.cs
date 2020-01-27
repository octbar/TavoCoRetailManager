using System.Collections.Generic;
using TRMDataManager.Library.Models;

namespace TRMDataManager.Library.DataAccess
{
    public interface ISaleData
    {
        List<SaleReportModel> GetSalereport();
        void SaveSale(SaleModel saleInfo, string cashierId);
    }
}