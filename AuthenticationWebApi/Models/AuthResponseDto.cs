namespace AuthenticationWebApi.Models
{
    public class AuthResponseDto
    {
        public bool IsSuccess { get; set; } = false;
        public string Message { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
    }
}
