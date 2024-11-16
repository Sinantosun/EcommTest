namespace EcommTest.DAL.Entites
{
    public class ProductAttrubute
    {
        public int ProductAttrubuteID { get; set; }
        public string Name { get; set; } //Numara, Beden, GB Ram kamera vb. renk burada bunlar tutulacak.
        public List<ProductDetail> productDetails { get; set; }

       
    }
}
