using System;

namespace LoginSystem.Domain.Models
{
    public class Account : DomainObject
    {
        public User AccountHolder { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
