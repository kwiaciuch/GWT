using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWT.Model
{
    public class ListingPositionDTO
    {
        /// <summary>
        /// Gets or sets the listings - number of people who lists (sells or orders) item.
        /// </summary>
        public int Listings { get; set; }
        /// <summary>
        /// Gets or sets the unit price for item.
        /// </summary>
        public int Unit_Price { get; set; }
        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        public int Quantity { get; set; }
    }
}
