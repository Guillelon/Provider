using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProviderDBContext: DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<TypeProduct> TypeProduct { get; set; }
        public DbSet<SaleDetail> SaleDetail { get; set; }
    }
}
