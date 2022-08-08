using System.Text.Json.Serialization;

using HttpTracer;

using RestSharp;
using RestSharp.Authenticators;

namespace Midnight.Sdk;

internal class MidnightAuthenticator : AuthenticatorBase
{
    private readonly string _baseUrl;
    private readonly string _userName;
    private readonly string _password;
    private DateTimeOffset _expires;

    public MidnightAuthenticator(string baseUrl, string userName, string password) : base("")
    {
        _baseUrl = baseUrl;
        _userName = userName;
        _password = password;
    }

    protected override async ValueTask<Parameter> GetAuthenticationParameter(string accessToken)
    {
        if (_expires < DateTimeOffset.UtcNow || string.IsNullOrEmpty(Token))
            Token = await GetToken();

        return new HeaderParameter(KnownHeaders.Authorization, Token);
    }

    private async Task<string> GetToken()
    {
        var options = new RestClientOptions(_baseUrl)
        {
            ConfigureMessageHandler = handler => new HttpTracerHandler(handler)
        };

        using var client = new RestClient(options);

        var request = new RestRequest("Token/UserAuthentication");

        request.AddJsonBody(new MidnightAuthRequest
        {
            DomainName = "UMS",
            UserName = _userName,
            Password = _password,
            IsPasswordEncrypted = false
        });

        var response = await client.PostAsync<TokenResponse>(request);

        _expires = DateTimeOffset.UtcNow.AddMilliseconds(response!.ExpiresIn);

        return $"Bearer {response!.AccessToken}";
    }

    private record MidnightAuthRequest
    {
        public string DomainName { get; set; } = default!;
        public string UserName { get; set; } = default!;
        public string Password { get; set; } = default!;
        public bool IsPasswordEncrypted { get; set; }
    }

    private record TokenResponse
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; } = default!;

        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }
    }
}
