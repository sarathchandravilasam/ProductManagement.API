using System.ComponentModel.DataAnnotations.Schema;

namespace ProductManagement.API.Models;

public class Order
{
    public int Id { get; set; }
    [ForeignKey("Product")]
    public int OrderId { get; set; }
    [ForeignKey("Customer")]
    public int CustomerId { get; set; }
    public required string Category { get; set; }
    public required string Region { get; set; }
    public DateTime DateOfSale { get; set; }
    public int QuanititySold { get; set; }
    public string Discount { get; set; } = string.Empty;
    public float ShippingCost { get; set; }
    public required string PaymentMethod { get; set; }
}
