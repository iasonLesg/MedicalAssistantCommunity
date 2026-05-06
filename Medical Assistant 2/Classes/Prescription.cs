using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAssistantCommunity.Classes
{
    public class Prescription
    {
        public int ID { get; set; }
        public bool Active { get; set; }
        public DateTime TimeReleased { get; set; }
        public string PrescriptionName { get; set; }
        public string PrescriptionDetails { get; set; }
    }
}
