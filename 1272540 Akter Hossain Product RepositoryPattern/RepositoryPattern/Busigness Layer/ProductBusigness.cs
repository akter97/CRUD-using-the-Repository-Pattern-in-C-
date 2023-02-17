using RepositoryPattern.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Busigness_Layer
{
    public class ProductBusigness
    {
       public IProductRepository Repository;
        public ProductBusigness(IProductRepository repository)
        {
            Repository = repository;
        }
        public List<ProductList> Get()
        {
            return Repository.Get();
        }
        public ProductList Get(int id)
        {
            return Repository.Get(id);
        }
        public bool Add(ProductList List_Add)
        {
            return Repository.Add(List_Add);
        }
        public bool Update(ProductList List_Update)
        {
            return Repository.Update(List_Update);
        }
       public bool Delete(int productId)
        {
            return Repository.Delete(productId);    
        }
    }
}
