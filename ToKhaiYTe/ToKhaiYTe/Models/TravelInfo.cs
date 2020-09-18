using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYTe.Models
{
    public class TravelInfo
    {
        public int Id { get; set; }
        public bool Airplane { get; set; }
        public bool Ships { get; set; }
        public bool Car { get; set; }
        public string Details { get; set; }
        public string VehicleNum { get; set; }
        public int DepartureDateId{ get; set; }
        public int EntryDateId{ get; set; }
        public string SeatNum { get; set; }
        public int DepartureProvinceId { get; set; }
        public int EntryProvinceId { get; set; }
        public string RecentInfo { get; set; }

        public ICollection<MedicalForm> MedicalForms { get; set; }
    }
}
