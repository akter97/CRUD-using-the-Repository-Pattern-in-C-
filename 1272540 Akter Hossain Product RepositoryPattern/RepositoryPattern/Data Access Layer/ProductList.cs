using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Data_Access_Layer
{
    public class ProductList
    {
        public int ProductId;
        public string ProductName;
        public double Amount;
        public CategoryType Category;
        public string ProductDecript;

        public ProductList()
        {

        }
        public ProductList(int productId, string productName, double amount, CategoryType category,string productDecript) : this()
        {
            ProductId = productId;
            ProductName = productName;
            Amount = amount;
            Category = category;
            ProductDecript = productDecript;
    }
    }
    }
