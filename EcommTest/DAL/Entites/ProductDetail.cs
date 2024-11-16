namespace EcommTest.DAL.Entites
{
    public class ProductDetail
    {
        public int ProductDetailID { get; set; }
        public int ProductAttrubuteID { get; set; }
        public ProductAttrubute productAttrubute { get; set; }
        public string TypeValue { get; set; }

      

        public Products Products { get; set; }
        public int ProductsID { get; set; }
    }
}
