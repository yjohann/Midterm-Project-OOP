using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project_OOP
{
    internal class Product
    {
        private string _productName;
        private int _productQuantity; 
        private string _productType; 

     
        public Product(string productName, int productQuantity, string productType)
        {
            _productName = productName;
            _productQuantity = productQuantity;
            _productType= productType;
        }

        /// <summary>
        /// Show the product name and quantity
        /// </summary>
        /// <returns></returns>
        public string ShowProduct()
        {
            return $"{_productName}:  \t{_productQuantity}";
        }

        /// <summary>
        /// Adding or subtracting product stocks
        /// </summary>
        /// <param name="numStock"></param>
        public void AdjustProductStock(int numStock)
        {
             _productQuantity += numStock;                     
        }
        
        /// <summary>
        /// Identify what kin of product is that
        /// </summary>
        /// <returns></returns>
        public string GetProductType()
        {           
            return _productType;
        }

        public int GetProductValue()
        {
            return _productQuantity;
        }

        /// <summary>
        /// Checker if the product quantity is low
        /// </summary>
        /// <returns></returns>
        public bool StockLowCheck()
        {           

            if (_productQuantity < 5)
            {
                return true; 
            }

            return false;
        }




    }
}
