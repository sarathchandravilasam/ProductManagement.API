using CsvHelper.Configuration;
using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Globalization;

namespace ProductManagement.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductManagementController : ControllerBase
{
    [HttpPost("insert-from-csv")]
    public async Task<IActionResult> InsertDataFromCsv()
    {
        List<(string CsvColumn, string TableColumn)> columns = [
            ("DocumentNumber", "doc_no"),
            ("DocumentDate", "doc_date"),
            ("Customer", "cust_name"),
            ("Product", "prod_name")
        ];

        string filepath = @"D:\Training\ProductManagement.API\ProductManagement.API\sample.csv";

        using var reader = new StreamReader(filepath);
        var csvConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture);
        var csvReader = new CsvReader(reader, csvConfiguration);

        var dataTable = new DataTable();

        var dataReader = new CsvDataReader(csvReader);

        foreach (var coulmn in columns)
        {

        }

    }
}
