using Repository;
using Repository.Repos;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
namespace Api.Controllers
{
    public class ProductController : ApiController
    {
        private UnitOfWork _unitOfWork;
        public ProductController()
        {
            _unitOfWork = new UnitOfWork();
        }

        // GET: api/Product
        public IQueryable<Product> Get()
        {
            var products = _unitOfWork.ProductRepository.GetAll();            
            return products;
        }

        // GET: api/Product/5
        public Product Get(int id)
        {
            var product = _unitOfWork.ProductRepository.GetByID(id);
            return product;
        }
        
        public IQueryable<Product> GetProducByTypeId(int id)
        {
            var products = _unitOfWork.ProductRepository.GetByTypeProductId(id);
            return products;
        }
    }    
}
