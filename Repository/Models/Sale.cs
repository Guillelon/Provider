using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }

        public ICollection<SaleDetail> SaleDetails { get; set; }
    }
}
