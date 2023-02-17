using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Data_Access_Layer
{
   public interface IProductRepository
    {
        List<ProductList> Get();
        ProductList Get(int productId);
        bool Add(ProductList List_Add);
        bool Update(ProductList List_Update);
        bool Delete(int productId);


    }
}
