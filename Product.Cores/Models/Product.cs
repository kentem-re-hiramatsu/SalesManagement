namespace Products.Cores.Models
{
    public class Product
    {
        public string Name { get; }
        public int Id { get; set; }

        public Product(string name)
        {
            Name = name;
        }
    }
}
