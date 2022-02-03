using System;

namespace Bank.Web.API.Models
{
    public class Account
    {
        public int Number { get; set; }
        public int CV { get; set; }
        public DateTime ValidateDate { get; set; }
    }
}
