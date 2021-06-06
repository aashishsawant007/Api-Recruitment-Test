using Portfolio.Standard.Entities;
using Portfolio.Standard.Models;
using System.Threading.Tasks;

namespace Portfolio.Standard.DAL
{
    public class BaseRepository : Contracts.DAL.IBaseRepository
    {
        public BaseRepository()
        {

        }
        public async Task<ResponseMessage> InsertStock(StockEntity stockEntity)
        {
            ResponseMessage responseMessage = new ResponseMessage();
            using(var context = new PortfolioContext())
            {
                var entity = context.stocks.Add(stockEntity);
                entity.State = Microsoft.EntityFrameworkCore.EntityState.Added;
                context.SaveChanges();
                responseMessage.Message = "Saved";
                responseMessage.Status = ResponseStatus.Success;
            }
            return responseMessage;
        }
    }
}
