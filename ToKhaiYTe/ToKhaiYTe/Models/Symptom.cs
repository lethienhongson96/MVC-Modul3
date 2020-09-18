using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYTe.Models
{
    public class Symptom
    {
        public int Id { get; set; }
        public bool Sot { get; set; }
        public bool Ho { get; set; }
        public bool KhoTho { get; set; }
        public bool DauHong { get; set; }
        public bool BuonNon { get; set; }
        public bool TieuChay { get; set; }
        public bool XuatHuyetNgoaiDa { get; set; }
        public bool NoiBanNgoaiDa { get; set; }
        public string VacxinDaSuDung{ get; set; }
        public int LichSuPhoiNhiemId { get; set; }

        public ICollection<MedicalForm> MedicalForms { get; set; }
    }
}
