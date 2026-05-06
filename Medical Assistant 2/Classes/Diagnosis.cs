using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAssistantCommunity.Classes
{
    public class Diagnosis
    {
        public int ID { get; set; }
        public bool Active { get; set; }
        public DateTime TimeReleased { get; set; }
        public string DiagnosisText { get; set; }
    }
}
