using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SaleDetail
    {
        public int Id { get; set; }
        public int ProductQuantity { get; set; }

        public int SaleId { get; set; }
        public Sale Sale { get; set; }
        
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
