using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWT.Model
{
    /// <summary>
    /// Object containing list of categories for Materials
    /// </summary>
    public class CategoryItemsListDTO
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        public int[] Items { get; set; }
        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        public int Order { get; set; }
    }
}
