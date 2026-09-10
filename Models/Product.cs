namespace MakeupBlazorProject.Models;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string? Brand { get; set; }
    public decimal Price { get; set; }

    public int CategoryId { get; set; }

    public Category Category { get; set; } = null!;
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
}