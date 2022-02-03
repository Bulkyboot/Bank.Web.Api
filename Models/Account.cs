using Bank.Web.API.Models.Base;
using System;

namespace Bank.Web.API.Models
{
    public class Account : BaseEntity
    {
        public int Number { get; set; }
        public int CV { get; set; }
        public DateTime ValidateDate { get; set; }
    }
}
