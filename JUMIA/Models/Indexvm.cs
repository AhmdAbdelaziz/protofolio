namespace WebApplication9.Models
{
    public class Indexvm
    {
        public Indexvm()
        {
            categories=new List<Category>();
            products=new List<Product>();
            reviews=new List<Review>();
            latestproducts = new List<Product>();

        }
        public List<Category> categories { get; set; }
        public List<Product> products { get; set; }
        public List<Review> reviews { get; set; }
        public List<Product> latestproducts { get; set; }
    }
}
