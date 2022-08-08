namespace Midnight.Sdk.Models;

public class AuthenticationResponse
{
    public string AccessToken { get; set; } = default!;
    public string RefreshToken { get; set; } = default!;
    public string TokenType { get; set; } = default!;
    public int ExpiresIn { get; set; }
}
