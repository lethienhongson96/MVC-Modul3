using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagement.Models.Entities
{
    public class Ward
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Prefix { get; set; }
        public int? ProvinceId { get; set; }
        public int? DistrictId { get; set; }
    }
}
