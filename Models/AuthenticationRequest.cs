namespace Midnight.Sdk.Models;

public class AuthenticationRequest
{
    public string DomainName { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string Password { get; set; } = default!;
    public bool IsPasswordEncrypted { get; set; }
}
