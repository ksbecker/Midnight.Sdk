using HttpTracer;

using Midnight.Sdk.Models;

using RestSharp;

namespace Midnight.Sdk;

public class MidnightClient : IMidnightClient, IDisposable
{
    private readonly RestClient _client;
    private bool disposedValue;

    public MidnightClient(string baseUrl, string userName, string password)
    {
        var options = new RestClientOptions(baseUrl)
        {
            ConfigureMessageHandler = handler => new HttpTracerHandler(handler)
        };

        _client = new RestClient(options)
        {
            Authenticator = new MidnightAuthenticator(baseUrl, userName, password)
        };
    }

    public async Task<IEnumerable<CustomerListResponse>?> CustomerListAsync(CancellationToken cancellationToken = default)
    {
        var request = new RestRequest("Customer/CustomerList");
        var response = await _client.PostAsync<IEnumerable<CustomerListResponse>>(request, cancellationToken);

        return response;
    }

    public async Task<IEnumerable<OrderListResponse>?> OrderListAsync(OrderListRequest orderListRequest, CancellationToken cancellationToken = default)
    {
        var response = await _client.PostJsonAsync<OrderListRequest, IEnumerable<OrderListResponse>>("Order/OrderList", orderListRequest, cancellationToken);

        return response;
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
                _client?.Dispose();

            disposedValue = true;
        }
    }

    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
