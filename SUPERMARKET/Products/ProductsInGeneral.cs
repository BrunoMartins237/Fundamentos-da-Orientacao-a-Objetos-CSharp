namespace SUPERMARKET1.Products
{
    public abstract class ProductsInGeneral
    {
        protected ProductsInGeneral(string nameOfProduct, 
        int priceOfProduct)
        {
            NameOfProduct = nameOfProduct;
            PriceOfProduct = priceOfProduct;
        }

        public string NameOfProduct { get; set; }
        public int PriceOfProduct { get; set; }
        
    }
}