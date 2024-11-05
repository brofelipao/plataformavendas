namespace PlataformaVendas.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public int? ProductParentId { get; set; }
        public virtual Category? Category { get; set; }
        public virtual Product? ProductParent { get; set; }
        public IEnumerable<Product>? ProductsChildren { get; set; }
        public IEnumerable<ProductDocument>? Documents { get; set; }
    }
}
