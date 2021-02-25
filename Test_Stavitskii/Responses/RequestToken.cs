namespace Test_Stavitskii.Responses
{
    public class RequestTokenResponse
    {
        public string RequestToken { get; set; }
        public int Expires { get; }
        public bool Success { get; }
    }
}