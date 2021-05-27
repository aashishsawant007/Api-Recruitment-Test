using Microsoft.EntityFrameworkCore;

namespace Portfolio.Standard.DAL
{
    public class PortfolioContext : DbContext
    {
        public PortfolioContext(DbContextOptions options) : base(options)
        {

        }
    }
}
