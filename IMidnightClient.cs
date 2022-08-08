using Midnight.Sdk.Models;

namespace Midnight.Sdk;

public interface IMidnightClient
{
    Task<IEnumerable<CustomerListResponse>?> CustomerListAsync(CancellationToken cancellationToken = default);
    Task<IEnumerable<OrderListResponse>?> OrderListAsync(OrderListRequest request, CancellationToken cancellationToken = default);
}
