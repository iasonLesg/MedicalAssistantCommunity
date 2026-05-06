using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAssistantCommunity.Classes
{
    public class Appointment
    {

        public string Name { get; set; }

        public int PatientID { get; set; }
        public int ID { get; set; }
        public DateTime TimeScheduled { get; set; }
        public int ApointmentDuration { get; set; } //minutes
        public DateTime Timestamp { get; set; }
        public string AppointmentReview { get; set; }
        public Appointment()
        {
            Timestamp = DateTime.Now;
            ID = MainWindow.Appointments.Count;
            Name = "";
            PatientID = -1;
            AppointmentReview = "";
            TimeScheduled = DateTime.Now;
            ApointmentDuration = 60;
        }
        public Appointment(int id, int PatientID, string name, DateTime TimeScheduledte, int duration)
        {
            Timestamp = DateTime.Now;
            ID = id;
            Name = name;
            this.PatientID = PatientID;
            AppointmentReview = "";
            TimeScheduled = TimeScheduledte;
            ApointmentDuration = duration;
        }
    }
}
