using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VendorMachineProj.Coin;

namespace VendorMachineProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!!");
            Console.WriteLine("Prodcut List and Price -");
            VendingMachine objVend = new VendingMachine();
            foreach (var data in objVend.GetProductList())
            {
                Console.WriteLine("Prodcut Name : {0}  ,Product Code : {1}  , Price :{2} $",data.ProductName,data.ProductCode,data.ProductPrice);

            }
            ProductCode:
            Console.WriteLine("Please Enter Valid Product Code :");
            string productcode = Console.ReadLine();
            var Product = objVend.GetProductList().Where(a => a.ProductCode == productcode)?.FirstOrDefault();
            if (Product != null)
            {
                Coins:
                Console.WriteLine("Please Insert Valid Coins :");
                string Coins = Console.ReadLine().ToLower();

                ICoin CoinObj = GetCoin(Coins);
                if (CoinObj != null)
                {
                    float CoinPrice = CoinObj.CointValue();
                    objVend.dipositecoin(CoinPrice);

                   string msg = objVend.GetProduct(productcode);
                    if (msg.Equals("success", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Please collect the product : {0}", Product.ProductName);
                        Console.WriteLine("Collect Remaining Balance  : {0}", objVend.depositAmount);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Coins");
                        Console.WriteLine("Desposited Amount:{0}", objVend.depositAmount);
                        goto Coins;
                    }


                }
                else
                {
                    goto Coins;
                }
            }
            else
            {
                goto ProductCode;

            }

            Console.ReadLine();
        }
        public static ICoin GetCoin(string coin)
        {
            if (coin == "nickel")
            {
                return new nickel();
            }
            if (coin == "demies")
            {
                return new demies();
            }
            if (coin == "quarters")
            {
                return new quarters();
            }
            if (coin == "pennies")
            {
                return new pennies();
            }
            else
            {
                return null;
            }


        }



    }
}
