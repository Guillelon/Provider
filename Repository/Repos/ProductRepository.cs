using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repos
{
    public class ProductRepository : MasterRepository<Product>
    {
        public ProductRepository(ProviderDBContext context) : base(context)
        {
            this.context = context;
        }

        public virtual IQueryable<Product> GetByTypeProductId(int typeProductId)
        {
            return context.Product.Where(p => p.TypeProductId == typeProductId);
        }
    }
}
