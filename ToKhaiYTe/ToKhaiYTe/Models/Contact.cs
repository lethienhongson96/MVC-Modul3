using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYTe.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public int ProvinceId { get; set; }
        public int DistrictId { get; set; }
        public int WardId { get; set; }
        public string HouseNum{ get; set; }
        public int PhoneNum{ get; set; }
        public string Email{ get; set; }

    }
}
