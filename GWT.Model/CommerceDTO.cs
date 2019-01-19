using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWT.Model
{
    /// <summary>
    /// Object describing data got from GW2Api about item edge values (highest seller, biggest biggest) on TP
    /// </summary>
    public class CommerceDTO
    {
        public int Id { get; set; }
        public bool Whitelisted { get; set; }
        public MarketPriceDTO Buys { get; set; }
        public MarketPriceDTO Sells { get; set; }
    }
}
