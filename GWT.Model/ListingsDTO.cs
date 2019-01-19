using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWT.Model
{
    public class ListingsDTO
    {
        /// <summary>
        /// Gets or sets the item identifier.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the buys (<see cref="ListingPositionDTO"/>).
        /// </summary>
        public ListingPositionDTO[] Buys { get; set; }
        /// <summary>
        /// Gets or sets the sells (<see cref="ListingPositionDTO"/>).
        /// </summary>
        public ListingPositionDTO[] Sells { get; set; }
    }
}
