namespace EcommTest.DAL.Entites
{
    public class Products
    {
        public int ProductsID { get; set; }
        public string ProductName { get; set; }
        public string Stok { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        public List<ProductDetail> productDetails { get; set; }
    }
}
