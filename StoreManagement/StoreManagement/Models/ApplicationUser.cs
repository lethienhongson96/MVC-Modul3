using Microsoft.AspNetCore.Identity;
using StoreManagement.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagement.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public int AddressId { get; set; }

        public Address Address { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
