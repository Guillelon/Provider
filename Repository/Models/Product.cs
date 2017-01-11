using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal SalePrice { get; set; }
        public decimal PurchasePrice { get; set; }

        public int TypeProductId { get; set; }
        public TypeProduct TypeProduct { get; set; }
    }
}
