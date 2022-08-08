using System.Text.Json.Serialization;

namespace Midnight.Sdk.Models;

public class OrderListResponse
{
    public int OrderID { get; set; }
    public string OrderNumber { get; set; } = default!;
    public int CustomerID { get; set; }
    public string CustomerName { get; set; } = default!;
    public string ContactName { get; set; } = default!;
    public string SalesRepName { get; set; } = default!;
    public string CSRName { get; set; } = default!;
    public string ProjectName { get; set; } = default!;
    public string LicenseeName { get; set; } = default!;
    public string PurchaseOrderNumber { get; set; } = default!;
    public string Terms { get; set; } = default!;
    public bool Taxable { get; set; }
    public string OrderStatus { get; set; } = default!;
    public string OrderDate { get; set; } = default!;
    public string DataInDate { get; set; } = default!;
    public string MaterialInDate { get; set; } = default!;
    public string ArtworkInDate { get; set; } = default!;
    public string DueDate { get; set; } = default!;
    public string CloseDate { get; set; } = default!;
    public int QuantityExpected { get; set; }
    public string OrderProgressCode { get; set; } = default!;
    public string OrderProgressText { get; set; } = default!;
    public float OrderTax { get; set; }
    public float OrderTotal { get; set; }
    public OrderUdflist UDFList { get; set; } = default!;
}

public class OrderUdflist
{
    [JsonPropertyName("UDF19")]
    public string? ListPurchase { get; set; }

    [JsonPropertyName("UDF20")]
    public string? SuppressListRenewalEmail { get; set; }
}