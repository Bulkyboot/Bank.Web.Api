namespace Bank.Web.API.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public int account { get; set; }
        public int passoword { get; set; }
        public int AgenciAccount { get; set; }
    }
}
