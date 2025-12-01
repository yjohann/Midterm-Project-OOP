using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project_OOP
{
    internal class RunSystem
    {

        public void Run()
        {
            //create the products
            Product product1 = new Product("apple", 5, "fruit");
            Product product2 = new Product("banana", 6,"fruit");
            Product product3 = new Product("orange", 4, "fruit");

            Product product4 = new Product("spinach", 7, "vegetable");
            Product product5 = new Product("eggplant", 6, "vegetable");
            Product product6 = new Product("potato", 9, "vegetable");

            //create storage for products
            List<Product> products = new List<Product>();

            //store the products in storage
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);
            products.Add(product5);
            products.Add(product6);

            bool start1 = true;
            while (start1)
            {
                Console.WriteLine(" 1. View stock levels. ");
                Console.WriteLine(" 2. Update stock quantities. ");
                Console.WriteLine(" 3. Generate stock summary. ");
                Console.WriteLine(" 4. Exit program. ");
                Console.WriteLine();
                Console.Write("Select the command you want to do: ");
                string inpt1 = Console.ReadLine();
                if(int.TryParse( inpt1, out int command))
                {
                    Console.Clear();
                    switch (command)
                    {
                        case 1:

                            Console.WriteLine("--- FRUITS ---");
                            for (int i = 0; i < products.Count; i++)
                            {
                                if (products[i].GetProductType().ToLower() == "fruit")
                                {
                                    Console.WriteLine(products[i].ShowProduct());
                                }
                            }

                            Console.WriteLine();

                            Console.WriteLine("--- VEGETABLES ---");
                            for (int i = 0; i < products.Count; i++)
                            {
                                if (products[i].GetProductType().ToLower() == "vegetable")
                                {
                                    Console.WriteLine(products[i].ShowProduct());
                                }
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 2:
                            Console.WriteLine("Stock for each product: \n");

                            for (int i = 0; i < products.Count; i++)
                            {
                                if (products[i].StockLowCheck())
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"{i + 1}. {products[i].ShowProduct()} restock\n");
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.WriteLine($"{i + 1}. {products[i].ShowProduct()}\n");
                                }

                            }
                            Console.Write("Select the product you want to update: ");
                            string inpt2 = Console.ReadLine();
                            if (int.TryParse(inpt2, out int numinpt1) && numinpt1 <= products.Count && numinpt1 > 0)
                            {
                                Console.Write("Input a positive number to add stock and negative to deduct: ");
                                string inpt3 = Console.ReadLine();
                                if (int.TryParse(inpt3, out int stockNum))
                                {
                                    if(stockNum <  products[numinpt1 - 1].GetProductValue() && products[numinpt1 - 1].GetProductValue() == 0)
                                    {
                                        Console.WriteLine("Input error!");
                                    }
                                    else
                                    {
                                        products[numinpt1 - 1].AdjustProductStock(stockNum);
                                        Console.WriteLine("Prodcut quantity adjusted successfully!");
                                    }
                                      
                                }
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 3:
                            bool lowStock = false;
                            Console.WriteLine("--- FRUITS ---");
                            for (int i = 0; i < products.Count; i++)
                            {
                                if (products[i].GetProductType().ToLower() == "fruit")
                                {
                                    if (products[i].StockLowCheck() == true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine($"{i + 1}. {products[i].ShowProduct()} needs to be restocked!");
                                        lowStock = true;
                                        Console.ResetColor();
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine($"{i + 1}. {products[i].ShowProduct()} stock is good!");
                                        Console.ResetColor();
                                    }
                                }

                            }

                            if (lowStock == false)
                            {
                                Console.WriteLine($"All product quantity in inventory is still good.");
                            }
                            Console.WriteLine();

                            Console.WriteLine("--- VEGETABLES ---");
                            for (int i = 0; i < products.Count; i++)
                            {
                                if (products[i].GetProductType().ToLower() == "vegetable")
                                {
                                    if (products[i].StockLowCheck() == true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine($"{i + 1}. {products[i].ShowProduct()} needs to be restocked!");
                                        lowStock = true;
                                        Console.ResetColor();
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine($"{i + 1}. {products[i].ShowProduct()} stock is good!");
                                        Console.ResetColor();
                                    }
                                }

                            }
                            if (lowStock == false)
                            {
                                Console.WriteLine($"All product quantity in inventory is still good.");
                            }
                            Console.WriteLine();

                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 4:
                            start1 = false;
                            break;

                    }
                }
                              
            }                    
        }

    }
}
