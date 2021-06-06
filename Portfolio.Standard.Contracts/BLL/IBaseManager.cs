using Portfolio.Standard.Models;
using System.Threading.Tasks;

namespace Portfolio.Standard.Contracts.BLL
{
    public interface IBaseManager
    {
        Task<ResponseMessage> CreateStock(StockDto stock);
    }
}
