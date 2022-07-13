namespace AuthorizationAPI.Model
{
    public class SignInResponse
    {
        public bool IsSuccess { get; set; }
        public string Token { get; set; }

        public string Role { get; set; }
    }
}
