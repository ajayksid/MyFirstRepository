using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachineProj
{
    public class VendingMachine
    {

        public static List<Product> ProductList = new List<Product>();
        public  float depositAmount = 0.44f;
        public VendingMachine()
        {
            ProductList.Add(new Product { ProductID = 1, ProductCode = "Prod101", ProductName = "Cola", ProductPrice =1.00f });
            ProductList.Add(new Product { ProductID = 2, ProductCode = "Prod102", ProductName = "Chips", ProductPrice = .50f });
            ProductList.Add(new Product { ProductID = 3, ProductCode = "Prod103", ProductName = "Candey", ProductPrice = .65f });
            
        }

        public void dipositecoin(float coinamount)
        {
            depositAmount += coinamount;
        }

        public string GetProduct(string ProductCode)
        {
            var product = ProductList.Where(a => a.ProductCode == ProductCode).FirstOrDefault();
            if (product != null)
            {
                if (depositAmount >= product.ProductPrice)
                {
                    depositAmount = depositAmount - product.ProductPrice;
                    return "Success";
                }
                else
                {
                    return "Insufficient Amount";
                }
            }
            else
            {
                return "Invalid Product";
            }

        }

        public List<Product> GetProductList()
        {
            return ProductList; 

        }



    }
}
