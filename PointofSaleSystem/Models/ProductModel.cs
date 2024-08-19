using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointofSaleSystem.Models
{
    public class ProductModel
    {
        [PrimaryKey, AutoIncrement]
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public string? Quantity { get; set; }

        public string? Category { get; set; }
        public string? Description { get; set; }
        public string? Price { get; set; }

    }
}
