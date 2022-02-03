namespace Bank.Web.API.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; } 
        public string Cpf { get; set; }
        public int passoword { get; set; }
        public int AgenciAccount { get; set; }
        public long IdAccount { get; set; }
        public Account account { get; set; }

    }
}
