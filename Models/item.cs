using System.ComponentModel.DataAnnotations;

namespace Catalog.Model;

public class item
{
    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public decimal Price { get; set; }
    public DateTimeOffset CreatedDate { get; set; }
}   
