using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Data_Access_Layer
{
    public class ProductRepository:IProductRepository
    {
      public List<ProductList> productLists = new List<ProductList>()
        {
            new ProductList(201,"Acer",91900,CategoryType.Top,"Processor: AMD Ryzen 5 5500U (8M Cache, 2.1GHz up to 4.0GHz)"),
            new ProductList(202,"Acer",66640,CategoryType.Mid,"Processor: Intel Core i5-1135G7 (8M Cache, 2.40 GHz up to 4.20 GHz)"),
            new ProductList(203,"Acer",50925,CategoryType.Mid,"Processor: Intel Core i3-1115G4 (6M Cache, 3.00 GHz up to 4.10 GHz)"),
            new ProductList(204,"Acer",30200,CategoryType.Low,"Processor: Intel Celeron N4020 (4M Cache, 1.10 GHz up to 2.80 GHz)"),
            new ProductList(301,"HP",52000,CategoryType.Low,"Processor: Intel Core i3-1125G4 (8M Cache, 2.00 GHz up to 3.70 GHz)"),
            new ProductList(302,"HP",64000,CategoryType.Mid,"Processor: Intel Core i3-1215U (10M Cache, up to 4.40 GHz) "),
            new ProductList(303,"Hp",90000,CategoryType.Top,"Processor: Intel Core i5-1135G7 (8M Cache, 2.40 GHz up to 4.20 GHz)"),
            new ProductList(304,"Hp",120000,CategoryType.Top,"Processor: AMD Ryzen 5 5625U (16MB L3 Cache, 2.3GHz, up to 4.3GHz)"),
            new ProductList(402,"Dell",10000,CategoryType.Top,"Processor: Intel Core i5-10505 (12M Cache, up to 4.60 GHz)"),
            new ProductList(502,"Lenovo",71200,CategoryType.Mid,"Processor: Intel Core i7-10205 (12M Cache, up to 4.60 GHz)"),
            new ProductList(602,"Assus",60000,CategoryType.Low,"Processor: Intel Core i3-10505 (12M Cache, up to 4.60 GHz)")
        };
        public List<ProductList> Get()
        {
            return productLists.OrderBy(PL =>PL.ProductName).ToList();
        }
         
       public ProductList Get(int productId)
        {
           ProductList productListID = productLists.Where(PL =>PL.ProductId == productId).FirstOrDefault();
            return productListID;
        }
        public bool Add(ProductList List_Add)
        {
            productLists.Add(List_Add);
            return true;
        }
       public bool Update(ProductList List_Update)
        {
            bool isSublit = false;
            ProductList Submit = productLists.Where(PD => PD.ProductId==List_Update.ProductId).FirstOrDefault();
            if(Submit != null)
            {
                productLists.Remove(Submit);
                productLists.Add(Submit);
                isSublit = true;
            }
            return isSublit;


        }
       public bool Delete(int productId)
        {
            bool isSubmit = false;
            ProductList Submit = productLists.Where(PD => PD.ProductId ==productId).FirstOrDefault();
            if(Submit != null)
            {
                productLists.Remove(Submit);
                isSubmit= true;
            }
            return isSubmit;
        }
        


    }
    
}

