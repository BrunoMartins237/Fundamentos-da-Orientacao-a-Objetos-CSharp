using System.Collections.Generic;

namespace SUPERMARKET.Products
{
    public abstract class Products
    {

        public Products()
        {
            
        }
        public decimal PriceOfProducts { get; set; }
        public string NameOfProducts { get; set; }
        public int QuantityOfProducts { get; set; }
        public IList<Products> Product { get; set; }
        protected void AddProduct(Products products)
        {
            products.AddProduct(products);
        }
    }
}