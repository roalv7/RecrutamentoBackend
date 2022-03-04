namespace RecrutamentoWebAPI.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public string Number { get; set; }

        public string[] Interests { get; set; }

        public string? Message { get; set; }

    }
}
