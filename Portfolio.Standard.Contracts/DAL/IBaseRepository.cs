using Portfolio.Standard.Entities;
using Portfolio.Standard.Models;
using System.Threading.Tasks;

namespace Portfolio.Standard.Contracts.DAL
{
    public interface IBaseRepository
    {
        Task<ResponseMessage> InsertStock(StockEntity stockEntity);
    }
}
