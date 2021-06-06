using Portfolio.Standard.Contracts.BLL;
using Portfolio.Standard.Contracts.DAL;
using Portfolio.Standard.Models;
using System.Threading.Tasks;

namespace Portfolio.Standard.BLL
{
    public class BaseManager : IBaseManager
    {
        private IBaseRepository _baseRepositry;

        public BaseManager(IBaseRepository baseRepositry)
        {
            _baseRepositry = baseRepositry;
        }
        public async Task<ResponseMessage> CreateStock(StockDto stock)
        {
           return  await _baseRepositry.InsertStock(new Entities.StockEntity { StockId = stock.StockId, Name = stock.Name, Price = stock.Price, Quantity = stock.Quantity, UserID = stock.UserID});
        }
    }
}
