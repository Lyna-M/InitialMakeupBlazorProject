namespace MakeupBlazorProject.Models;

public class Review
{
    public int ReviewId { get; set; }

    public int ProductId { get; set; }

    public string CustomerName { get; set; } = string.Empty;

    public int Rating { get; set; }

    public string? Comment { get; set; }

    public Product Product { get; set; } = null!;
}