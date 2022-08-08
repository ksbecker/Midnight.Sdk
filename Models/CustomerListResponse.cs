using System.Text.Json.Serialization;

namespace Midnight.Sdk.Models;

public class CustomerListResponse
{
    public int CustomerID { get; set; }
    public string CustomerCode { get; set; } = default!;
    public string CustomerName { get; set; } = default!;
    public int CustomerTypeID { get; set; }
    public string EmailAddress { get; set; } = default!;
    public string Active { get; set; } = default!;
    public int ParentCustomerID { get; set; }
    public string LicenseeID { get; set; } = default!;
    public string LicenseeName { get; set; } = default!;
    public string AccountingCode { get; set; } = default!;
    public string CustomerTypeName { get; set; } = default!;
    public string TermsCode { get; set; } = default!;
    public int SalesRepID { get; set; } = default!;
    public string SalesRepName { get; set; } = default!;
    public int CSRID { get; set; } = default!;
    public string CSRName { get; set; } = default!;
    public string EnterDate { get; set; } = default!;
    public string Taxable { get; set; } = default!;
    public string PermitNumber { get; set; } = default!;
    public string DeliveryMethodID { get; set; } = default!;
    public string DeliveryMethodName { get; set; } = default!;
    public string URL { get; set; } = default!;
    public string TaxJurisdictionID { get; set; } = default!;
    public string TaxJurisdictionName { get; set; } = default!;
    public string TaxExemptionID { get; set; } = default!;
    public string TaxExemptionName { get; set; } = default!;
    public string AccountStatusID { get; set; } = default!;
    public string AccountStatusName { get; set; } = default!;
    public string PORequired { get; set; } = default!;
    public string Notification { get; set; } = default!;
    public string NotificationText { get; set; } = default!;
    public Shippingaddress ShippingAddress { get; set; } = default!;
    public Billingaddress BillingAddress { get; set; } = default!;
    public Customeraddress CustomerAddress { get; set; } = default!;
    public CustomerUdflist UDFList { get; set; } = default!;
    public string MODProviderID { get; set; } = default!;
    public string PostageMarkupType { get; set; } = default!;
    public float PostageMarkupValue { get; set; }
    public object UnpaidBalanceLimit { get; set; } = default!;
}

public class CustomerUdflist
{
    [JsonPropertyName("UDF1")]
    public string? ListPurchaseContactName { get; set; }

    [JsonPropertyName("UDF2")]
    public string? ListPurchaseContactEmail { get; set; }
}

public class Shippingaddress
{
    public string ShippingAddressName { get; set; } = default!;
    public string ShippingAddressLine1 { get; set; } = default!;
    public string ShippingAddressLine2 { get; set; } = default!;
    public string ShippingAddressLine3 { get; set; } = default!;
    public string ShippingAddressCity { get; set; } = default!;
    public string ShippingAddressState { get; set; } = default!;
    public string ShippingAddressZip { get; set; } = default!;
    public string ShippingAddressCountry { get; set; } = default!;
    public string ShippingMethod { get; set; } = default!;
}

public class Billingaddress
{
    public string BillingAddressName { get; set; } = default!;
    public string BillingAddressLine1 { get; set; } = default!;
    public string BillingAddressLine2 { get; set; } = default!;
    public string BillingAddressLine3 { get; set; } = default!;
    public string BillingAddressCity { get; set; } = default!;
    public string BillingAddressState { get; set; } = default!;
    public string BillingAddressZip { get; set; } = default!;
    public string BillingAddressCountry { get; set; } = default!;
}

public class Customeraddress
{
    public string CustomerAddressLine1 { get; set; } = default!;
    public string CustomerAddressLine2 { get; set; } = default!;
    public string CustomerAddressLine3 { get; set; } = default!;
    public string CustomerAddressCity { get; set; } = default!;
    public string CustomerAddressState { get; set; } = default!;
    public string CustomerAddressZip { get; set; } = default!;
    public string CustomerAddressCountry { get; set; } = default!;
}
