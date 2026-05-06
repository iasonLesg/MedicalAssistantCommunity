using MedicalAssistantCommunity.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace MedicalAssistantCommunity
{
    /// <summary>
    /// Interaction logic for AddPatientWindow.xaml
    /// </summary>
    public partial class AddPatientWindow : Window
    {
        private Patient _FirstPatient = new Patient();
        public bool Del = false;
        public List<Prescription> prescriptions = new List<Prescription>();
        public Patient CurrentPatient = new Patient();
        private List<Diagnosis> patientDiagnosis = new List<Diagnosis>();
        private PatientHistory _patientHistory = new PatientHistory();
        private bool _isEditMode = false;

        // Constructor for ADD MODE
        public AddPatientWindow()
        {
           
            InitializeComponent();
            LoadLanguage(false);
            ComboSex.SelectedIndex = 0; // Default to Undefined
            BTN_DeleteInterface.Visibility = Visibility.Collapsed;
        }

        private void LoadLanguage(bool edit) {

            LBL_Year.Text = LanguadgeReady.year.GetText(LanguadgeReady.selectedlanguadge);
            LBL_Day.Text = LanguadgeReady.day.GetText(LanguadgeReady.selectedlanguadge);
            LBL_Month.Text = LanguadgeReady.month.GetText(LanguadgeReady.selectedlanguadge);

            Lbl_RegistrationDate.Text = LanguadgeReady.releaseDate.GetText(LanguadgeReady.selectedlanguadge);
            Lbl_FullName.Text = LanguadgeReady.fullName.GetText(LanguadgeReady.selectedlanguadge);
            Lbl_Gender.Text = LanguadgeReady.gender.GetText(LanguadgeReady.selectedlanguadge);
            Lbl_SocialSecurity.Text = LanguadgeReady.socialSecurityNumber.GetText(LanguadgeReady.selectedlanguadge);
            Lbl_BirthDate.Text = LanguadgeReady.dateOfBirth.GetText(LanguadgeReady.selectedlanguadge);

            DobMonth.Items[0]= LanguadgeReady.january.GetText(LanguadgeReady.selectedlanguadge);
            DobMonth.Items[1]= LanguadgeReady.february.GetText(LanguadgeReady.selectedlanguadge);
            DobMonth.Items[2] = LanguadgeReady.march.GetText(LanguadgeReady.selectedlanguadge);
            DobMonth.Items[3] = LanguadgeReady.april.GetText(LanguadgeReady.selectedlanguadge);
            DobMonth.Items[4] = LanguadgeReady.may.GetText(LanguadgeReady.selectedlanguadge);
            DobMonth.Items[5] = LanguadgeReady.june.GetText(LanguadgeReady.selectedlanguadge);
            DobMonth.Items[6] = LanguadgeReady.july.GetText(LanguadgeReady.selectedlanguadge);
            DobMonth.Items[7] = LanguadgeReady.august.GetText(LanguadgeReady.selectedlanguadge);
            DobMonth.Items[8] = LanguadgeReady.september.GetText(LanguadgeReady.selectedlanguadge);
            DobMonth.Items[9] = LanguadgeReady.october.GetText(LanguadgeReady.selectedlanguadge);
            DobMonth.Items[10] = LanguadgeReady.november.GetText(LanguadgeReady.selectedlanguadge);
            DobMonth.Items[11] = LanguadgeReady.december.GetText(LanguadgeReady.selectedlanguadge);


            Lbl_Phone.Text = LanguadgeReady.phoneNumber.GetText(LanguadgeReady.selectedlanguadge);

            Lbl_PatientHistory.Text = LanguadgeReady.patientHistory.GetText(LanguadgeReady.selectedlanguadge);
            Lbl_ViewMedical.Text = LanguadgeReady.viewMedicalTimeline.GetText(LanguadgeReady.selectedlanguadge);
            Lbl_Diagnosis.Text = LanguadgeReady.diagnoses.GetText(LanguadgeReady.selectedlanguadge);
            Lbl_Perscriptions.Text = LanguadgeReady.prescriptions.GetText(LanguadgeReady.selectedlanguadge);

            ComboSex.Items[0] = LanguadgeReady.undefined.GetText(LanguadgeReady.selectedlanguadge);
            ComboSex.Items[1] = LanguadgeReady.male.GetText(LanguadgeReady.selectedlanguadge);
            ComboSex.Items[2] = LanguadgeReady.female.GetText(LanguadgeReady.selectedlanguadge);

            if (edit)
            {
                ModeLabel.Text = LanguadgeReady.editRecord.GetText(LanguadgeReady.selectedlanguadge);
                WindowTitle.Text = LanguadgeReady.modifyPatient.GetText(LanguadgeReady.selectedlanguadge);
                BtnSave.Content = LanguadgeReady.editRecord.GetText(LanguadgeReady.selectedlanguadge);
            }
            else {
                ModeLabel.Text = LanguadgeReady.registration.GetText(LanguadgeReady.selectedlanguadge);
                WindowTitle.Text = LanguadgeReady.addNewPatient.GetText(LanguadgeReady.selectedlanguadge);
                BtnSave.Content = LanguadgeReady.addNewPatient.GetText(LanguadgeReady.selectedlanguadge);
            }


            BtnCancel.Content = LanguadgeReady.cancel.GetText(LanguadgeReady.selectedlanguadge);
            DeletePatientBtn.Text = LanguadgeReady.deletePatient.GetText(LanguadgeReady.selectedlanguadge);
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            // Create the custom delete window
            DeleteMessageBox deleteWin = new DeleteMessageBox(LanguadgeReady.confirmDeleteAppointment.GetText(LanguadgeReady.selectedlanguadge));
            deleteWin.Owner = this; // Centers it over the current window

            // Show as a Dialog (stops user from clicking elsewhere)
            bool? isConfirmed = deleteWin.ShowDialog();

            if (isConfirmed == true)
            {
                // EXECUTE DELETE LOGIC HERE
                // e.g. DeleteFromDatabase();
                this.Del = true;
                this.Close(); // Close the diagnosis editor after deletion
            }
        }

        // Constructor for EDIT MODE
        public AddPatientWindow(Patient patientToEdit)
        {
          
        
            InitializeComponent();
            _FirstPatient = patientToEdit.Clone();
            double screenWidth = SystemParameters.WorkArea.Width;
            double screenHeight = SystemParameters.WorkArea.Height;
            this.Width = screenWidth * (2.5 / 3.0);
            this.Height = screenHeight * (2.5 / 3.0);
            this.Left = (screenWidth - this.Width) / 2.0;
            this.Top = (screenHeight - this.Height) / 2.0;
            CurrentPatient = patientToEdit;
            _isEditMode = true;
            if (CurrentPatient.Prescriptions != null) {
                prescriptions = CurrentPatient.Prescriptions;
            }
            if (CurrentPatient.Diagnosis != null) {
                patientDiagnosis = CurrentPatient.Diagnosis;
            }
            if (CurrentPatient.PatientHistory != null) {
                _patientHistory = CurrentPatient.PatientHistory;
            }
            // UI Adjustments
            ModeLabel.Text = "EDIT RECORD";
            WindowTitle.Text = "Modify Patient";
            BtnSave.Content = "Update Info";
            TimestampArea.Visibility = Visibility.Visible;
            LoadLanguage(true);
            // Map Data to UI
            TxtName.Text = CurrentPatient.Name;
            TxtSSN.Text = CurrentPatient.SocialSecurityNumber.ToString();
            TxtPhone.Text = CurrentPatient.PhoneNumber.ToString();
            TxtTimestamp.Text = CurrentPatient.Timestamp.ToString("g"); // Displays the immutable timestamp
            ComboSex.SelectedIndex = CurrentPatient.Sex;

            DobDay.Text = CurrentPatient.DateOfBirth.Day.ToString();
            DobMonth.SelectedIndex = CurrentPatient.DateOfBirth.Month - 1;
            DobYear.Text = CurrentPatient.DateOfBirth.Year.ToString();
            RefreshPrescriptionGallery();
            RefreshDiagnosisGallery();
            BTN_DeleteInterface.Visibility = Visibility.Visible;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (SaveCurrentPatient()) {
                    this.DialogResult = true;
                    this.Close();
                }

                
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(LanguadgeReady.numericValidation.GetText(LanguadgeReady.selectedlanguadge), this);
            }
        }

        private void OpenHistory_Click(object sender, RoutedEventArgs e)
        {

            var historyWindow = new PatientHistoryEdit(_patientHistory);


            historyWindow.Owner = this;
            historyWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;

            historyWindow.ShowDialog();

            if (historyWindow.DialogResult == true) {
                _patientHistory = historyWindow.Result;


            }
        }
        private void RefreshPrescriptionGallery()
        {
            // Bind the List<Prescription> to the ItemsControl
            if (CurrentPatient != null && CurrentPatient.Prescriptions != null)
            {
                ItemsPrescriptions.ItemsSource = null;
                ItemsPrescriptions.ItemsSource = CurrentPatient.Prescriptions;

            }
        }

        private void RefreshDiagnosisGallery()
        {
            // Bind the List<Prescription> to the ItemsControl
            if (CurrentPatient != null && CurrentPatient.Diagnosis != null)
            {
                ItemsDiagnoses.ItemsSource = null;
                ItemsDiagnoses.ItemsSource = CurrentPatient.Diagnosis;

            }
        }

        private void AddPrescription_Click(object sender, RoutedEventArgs e)
        {
            if (SaveCurrentPatient()) {

                // 1. Create a new prescription object
                var newPres = new Prescription { TimeReleased = DateTime.Now };

                // 2. Open Prescription Window in 'Add' mode
                PrescriptionWindow pWin = new PrescriptionWindow(newPres);
                pWin.Owner = this;
                if (pWin.ShowDialog() == true)
                {

                    CurrentPatient.Prescriptions.Add(newPres);
                    RefreshPrescriptionGallery();
                }
            }
           
        }

        private void AddDiagnosis_Click(object sender, RoutedEventArgs e)
        {

            if (SaveCurrentPatient())
            {
             
                var newPres = new Diagnosis { TimeReleased = DateTime.Now };

                AddDiagnosis pWin = new AddDiagnosis(newPres);
                pWin.Owner = this;
                if (pWin.ShowDialog() == true)
                {

                    CurrentPatient.Diagnosis.Add(newPres);
                    RefreshDiagnosisGallery();
                }
            }
        }

      

        private bool  SaveCurrentPatient() {
            // Simple validation could go here
            try {
                string name = TxtName.Text;

                int sex = ComboSex.SelectedIndex;

                long ssn = long.Parse(TxtSSN.Text);
                long phone = long.Parse(TxtPhone.Text);
                DateTime dob = new DateTime(int.Parse(DobYear.Text), DobMonth.SelectedIndex + 1, int.Parse(DobDay.Text));
                if (_isEditMode)
                {
                    // EDIT: Update existing reference
                    CurrentPatient.Name = name;
                    CurrentPatient.Sex = sex;
                    CurrentPatient.SocialSecurityNumber = ssn;
                    CurrentPatient.PhoneNumber = phone;
                    CurrentPatient.DateOfBirth = dob;
                    CurrentPatient.Prescriptions = prescriptions;
                    CurrentPatient.Diagnosis = patientDiagnosis;
                    CurrentPatient.PatientHistory = _patientHistory;
                }
                else
                {
                    // ADD: Create new object (Timestamp is handled in the Patient constructor)
                    // You would typically handle ID generation in your data service
                    Patient newPatient = new Patient(MainWindow.Patients.Count, sex, name, phone, ssn, dob, prescriptions, patientDiagnosis, _patientHistory);
                    CurrentPatient = newPatient;

                }
            }
            catch { CustomMessageBox.Show(LanguadgeReady.numericValidation.GetText(LanguadgeReady.selectedlanguadge), this);return false; }


            return true;
        }

        private void EditPrescription_Click(object sender, RoutedEventArgs e)
        {
            if (SaveCurrentPatient()) {

                // Get the prescription object from the button's DataContext
                if (((Button)sender).DataContext is Prescription selectedPres)
                {
                    PrescriptionWindow pWin = new PrescriptionWindow(selectedPres);
                    pWin.Owner = this;
                    pWin.ShowDialog();
                    if (pWin.Del)
                    {
                        CurrentPatient.Prescriptions.Remove(selectedPres);

                        RefreshPrescriptionGallery();
                    }
                    else if (pWin.DialogResult == true)
                    {
                        // User clicked Save, just refresh to show updated text
                        RefreshPrescriptionGallery();
                    }

                }

            }
          
        }
        private void EditDiagnosis_Click(object sender, RoutedEventArgs e)
        {
            if (SaveCurrentPatient())
            {

                if (((Button)sender).DataContext is Diagnosis selectedDiag)
                {
                    AddDiagnosis pWin = new AddDiagnosis(selectedDiag);
                    pWin.Owner = this;

                    // ShowDialog blocks execution until the window is closed
                    pWin.ShowDialog();

                    // Check if the delete flag was set inside the window
                    if (pWin.Del)
                    {
                        // Remove the specific diagnosis from the patient's list
                        CurrentPatient.Diagnosis.Remove(selectedDiag);

                        SaveCurrentPatient();
                        // Save changes to database/file here if necessary
                        // SaveCurrentPatient(); 

                        RefreshDiagnosisGallery();
                    }
                    else if (pWin.DialogResult == true)
                    {
                        // User clicked Save, just refresh to show updated text
                        RefreshDiagnosisGallery();
                    }
                }
            }
        }
        private void Cancel_Click(object sender, RoutedEventArgs e) {
            if (_isEditMode && _FirstPatient != null)
            {
                // We must map the properties back because CurrentPatient 
                // is a reference to the item in your MainWindow's list.
                CurrentPatient.Name = _FirstPatient.Name;
                CurrentPatient.Sex = _FirstPatient.Sex;
                CurrentPatient.SocialSecurityNumber = _FirstPatient.SocialSecurityNumber;
                CurrentPatient.PhoneNumber = _FirstPatient.PhoneNumber;
                CurrentPatient.DateOfBirth = _FirstPatient.DateOfBirth;

                // Very important: Restore the lists
                CurrentPatient.Prescriptions = _FirstPatient.Prescriptions;
                CurrentPatient.Diagnosis = _FirstPatient.Diagnosis;
                CurrentPatient.PatientHistory = _FirstPatient.PatientHistory;
            }
            this.Close(); 
        
        }
    }
}
