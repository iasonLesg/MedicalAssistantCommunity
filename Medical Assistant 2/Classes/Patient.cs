using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAssistantCommunity.Classes
{
    public enum SexVals
    {
        Undefined,
        Male,
        Female
    }
    public class Patient
    {
        public int ID { get; set; }
        public int Sex { get; set; }
        public string Name { get; set; }
        public long SocialSecurityNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

        public DateTime Timestamp { get; set; }

        public long PhoneNumber { get; set; }
        public List<Prescription> Prescriptions { get; set; }

        public List<Diagnosis> Diagnosis { get; set; }
        public PatientHistory PatientHistory { get; set; }
        public Patient()
        {
            ID = MainWindow.Patients.Count(); Sex = 0; Name = ""; SocialSecurityNumber = 0; DateOfBirth = DateTime.Now; Timestamp = DateTime.Now; PhoneNumber = 0;
            PatientHistory = new PatientHistory();
            Prescriptions = new List<Prescription>();
            Diagnosis = new List<Diagnosis>();
            PatientHistory = new PatientHistory();
        }
        public Patient(int id, int sex, string name, long phonenumber, long ssn, DateTime dob)
        {
            ID = id;
            Sex = sex;
            Name = name;
            SocialSecurityNumber = ssn;
            DateOfBirth = dob;
            Timestamp = DateTime.Now;
            PhoneNumber = phonenumber;
            Prescriptions = new List<Prescription>();
            PatientHistory = new PatientHistory();
            Diagnosis = new List<Diagnosis>();
            PatientHistory = new PatientHistory();
        }
        public Patient(int id, int sex, string name, long phonenumber, long ssn, DateTime dob, List<Prescription> Prescriptions, List<Diagnosis> DiagnosisIn, PatientHistory History)
        {
            ID = id;
            Sex = sex;
            Name = name;
            SocialSecurityNumber = ssn;
            DateOfBirth = dob;
            Timestamp = DateTime.Now;
            PhoneNumber = phonenumber;
            this.Prescriptions = Prescriptions;
            Diagnosis = DiagnosisIn;
            PatientHistory = History;

        }
        public Patient Clone()
        {
            // 1. Create a new Patient instance using basic properties via your constructor
            Patient clone = new Patient(
                ID,
                Sex,
                Name,
                PhoneNumber,
                SocialSecurityNumber,
                DateOfBirth
            );

            // 2. Explicitly copy the original Timestamp (don't use DateTime.Now)
            clone.Timestamp = Timestamp;

            // 3. Deep copy the Prescriptions List
            if (Prescriptions != null)
            {
                clone.Prescriptions = Prescriptions.Select(p => new Prescription
                {
                    ID = p.ID,
                    Active = p.Active,
                    TimeReleased = p.TimeReleased,
                    PrescriptionName = p.PrescriptionName,
                    PrescriptionDetails = p.PrescriptionDetails
                }).ToList();
            }

            // 4. Deep copy the Diagnosis List
            if (Diagnosis != null)
            {
                clone.Diagnosis = Diagnosis.Select(d => new Diagnosis
                {
                    ID = d.ID,
                    Active = d.Active,
                    TimeReleased = d.TimeReleased,
                    DiagnosisText = d.DiagnosisText
                }).ToList();
            }

            // 5. Deep copy the PatientHistory object
            if (PatientHistory != null)
            {
                clone.PatientHistory = new PatientHistory
                {
                    HistoryText = PatientHistory.HistoryText,
                    Allergies = PatientHistory.Allergies
                };
            }

            return clone;
        }
    }
    public class PatientHistory
    {
        public string HistoryText { get; set; }
        public string Allergies { get; set; }
    }
}


