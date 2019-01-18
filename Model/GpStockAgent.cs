using StockTradingSystem.Core.Access;
using StockTradingSystem.Core.Business;
using StockTradingSystem.Core.Model;

namespace StockTradingSystem.Client.Model
{
    public class GpStockAgent : StockAgent
    {
        public GpStockAgent(IUserAccess userAccess, IBusiness business, IUser user) : base(userAccess, business, user)
        {

        }
    }
}