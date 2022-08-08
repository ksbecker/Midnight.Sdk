namespace Midnight.Sdk.Models;

public class OrderListRequest : OrderUdflist
{
    public string? OrderNumber { get; set; }
    public string? CopyFromOrderNumber { get; set; }
    public string? CustomerCode { get; set; }
    public int? CustomerID { get; set; }
    public string? OrderDateFrom { get; set; }
    public string? OrderDateTo { get; set; }
    public string? OrderStatus { get; set; }
    public string? OrderDueDateFrom { get; set; }
    public string? OrderDueDateTo { get; set; }
    public string? OrderCloseDateFrom { get; set; }
    public string? OrderCloseDateTo { get; set; }
    public bool? OpenOrdersOnly { get; set; }
}
