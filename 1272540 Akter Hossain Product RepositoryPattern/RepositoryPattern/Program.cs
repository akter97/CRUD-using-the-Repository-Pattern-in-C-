using RepositoryPattern.Busigness_Layer;
using RepositoryPattern.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    public class Program
    {
      public  static void Main(string[] args)
        { 

            ProductBusigness OPB = new ProductBusigness(new ProductRepository());
            bool isSubmit = true;
            while (isSubmit)
            {
                try
                {
                    Console.WriteLine("Type 'List' for List, 'Insert' for Add, 'Update' for Update 'Delete' for Delete, 'Search' for Search,'clear' for Clear, 'Exit' for Exit");
                    string command = Console.ReadLine();
                    if (command == "List")
                    {
                        List<ProductList> OPL = OPB.Get();
                        Console.WriteLine("List of Product Detels:");
                        Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                        Console.WriteLine("P_Id \tP_Name \tP_Price \t P_Decription");
                        foreach (ProductList opl in OPL)
                        {

                            Console.WriteLine("   "+ opl.ProductId + "\t" + opl.ProductName + "\t" + opl.Amount + "\t" + opl.ProductDecript);
                        }
                        Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");


                    }
                    else if (command == "Search")
                    {

                        Console.WriteLine("================================================");
                        Console.WriteLine("Input a ProductID:");
                        string ProductId = Console.ReadLine();
                        ProductList opl = OPB.Get(Convert.ToInt32(ProductId));
                        Console.WriteLine("P_Id \tP_Name \tP_Price \t P_Decription");
                        Console.WriteLine(opl.ProductId + "\t"+ opl.ProductName +"\t" + opl.Amount + "\t" + opl.ProductDecript);

                        Console.WriteLine("================================================");
                    }
                    else if (command == "Insert")
                    {

                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("Input a Productid:");
                        string Productid = Console.ReadLine();
                        Console.WriteLine("Input a ProductName:");
                        string ProductName = Console.ReadLine();
                        Console.WriteLine("Input a Amount:");
                        string Amount = Console.ReadLine();
                        Console.WriteLine("Input a Product Decript:");
                        string ProductDecript = Console.ReadLine();

                        ProductList OPInsert = new ProductList();
                        OPInsert.ProductId = Convert.ToInt32(Productid);
                        OPInsert.ProductName = ProductName;
                        OPInsert.Amount = double.Parse(Amount); 
                        OPInsert.ProductDecript = ProductDecript;
                        Console.WriteLine("-----------------------------------------");

                        bool isSubmite = OPB.Add(OPInsert);
                        if (isSubmite)
                        {
                            Console.WriteLine("Added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add.");
                        }
                    }
                    else if (command == "Update")
                    {
                        Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");

                        Console.WriteLine("Input a Productid:");
                        string Productid = Console.ReadLine();
                        Console.WriteLine("Input a ProductName:");
                        string ProductName = Console.ReadLine();
                        Console.WriteLine("Input a Amount:");
                        string Amount = Console.ReadLine();
                        Console.WriteLine("Input a Product Decript:");
                        string ProductDecript = Console.ReadLine();
                        Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");

                        ProductList OPUpdate = new ProductList();
                        OPUpdate.ProductId = Convert.ToInt32(Productid);
                        OPUpdate.ProductName = ProductName;
                        OPUpdate.Amount = Convert.ToInt32(Amount);
                        OPUpdate.ProductDecript = ProductDecript;

                        bool isUpdate = OPB.Update(OPUpdate);
                        if (isUpdate)
                        {
                            Console.WriteLine("Updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to update.");
                        }
                    }
                    else if (command == "Detele")
                    {
                        Console.WriteLine("Input a ProductId:");
                        string Productid = Console.ReadLine();
                        bool isDelete = OPB.Delete(Convert.ToInt32(Productid));
                        if (isDelete)
                        {
                            Console.WriteLine("Deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to delete.");
                        }
                    }
                    else if (command == "clear")
                    {
                        Console.Clear();
                    }
                    else if (command == "x")
                    {
                       isSubmit  = false;
                    }
                    else
                    {
                        Console.WriteLine("Command not found.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            Console.ReadLine();
        }
    }
}
