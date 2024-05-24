namespace AuthenticateLoginAnRegistration.Dtos
{
    public class Status
    {
        public int StatusCode { get; set; } = 0;
        public string? StatusMessage  { get; set; }
        public string? Token  { get; set; }
        public string? Userid { get; set; }
    }
}
