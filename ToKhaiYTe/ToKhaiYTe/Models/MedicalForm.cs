using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYTe.Models
{
    public class MedicalForm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Passport { get; set; }

        public int GatesId { get; set; }
        public Gates Gates{ get; set; }

        //lay tu table years
        public int YearOfBirthId { get; set; }

        public int TravelInfoId { get; set; }
        public TravelInfo TravelInfo { get; set; }

        public int ContactId { get; set; }

        public int SymptomId { get; set; }
        public Symptom  Symptom{ get; set; }
    }
}
