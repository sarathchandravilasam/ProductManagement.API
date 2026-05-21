namespace ProductManagement.API.Models;

public class RawCsvRow
{
    public int OrderID { get; set; }
    public int ProductID { get; set; }
    public int CustomerID { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }
    public string Region { get; set; }
    public DateOnly DateOfSale { get; set; }
    public int QuantitySold { get; set; }
    public  float UnitPrice { get; set; }
}
