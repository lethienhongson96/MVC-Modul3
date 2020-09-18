using System;
using System.Collections.Generic;

namespace ToKhaiYTe.Models
{
    public partial class Gates
    {
        public int Id { get; set; }
        public string GateName { get; set; }
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<MedicalForm> MedicalForms{ get; set; }
    }
}
