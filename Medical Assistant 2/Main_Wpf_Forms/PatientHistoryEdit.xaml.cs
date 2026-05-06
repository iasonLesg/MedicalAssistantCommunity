using MedicalAssistantCommunity.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace MedicalAssistantCommunity
{
  
    public partial class PatientHistoryEdit : Window
    {
        public PatientHistory Result { get; private set; }

        public PatientHistoryEdit(PatientHistory existingData = null)
        {
            InitializeComponent();

            // If we are editing existing data, load it into the textboxes
            if (existingData != null)
            {
                TxtHistoryText.Text = existingData.HistoryText;
                TxtAllergies.Text = existingData.Allergies;
                LabelWindowTitle.Text = "Edit Patient History";
            }
            else
            {
                LabelWindowTitle.Text = "New Patient History";
            }
            GetLanguage();
        }

   
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // Simple validation: Ensure at least one field has data
            if (string.IsNullOrWhiteSpace(TxtHistoryText.Text) && string.IsNullOrWhiteSpace(TxtAllergies.Text))
            {
                CustomMessageBox.Show("Please enter either medical history or allergy information before saving.",this);
                return;
            }

            // Create the result object
            Result = new PatientHistory
            {
                HistoryText = TxtHistoryText.Text.Trim(),
                Allergies = TxtAllergies.Text.Trim()
            };

            // Set DialogResult to true so the calling window knows we saved
            this.DialogResult = true;
            this.Close();
        }


        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            // Optional: Add a confirmation if textboxes are not empty
           

            this.DialogResult = false;
            this.Close();
        }


        private void GetLanguage()
        {
            Lbl_Patient_Records.Text = LanguadgeReady.patientRecords.GetText(LanguadgeReady.selectedlanguadge);
            LabelWindowTitle.Text = LanguadgeReady.medicalHistoryAllergies.GetText(LanguadgeReady.selectedlanguadge);
            Lbl_General_Medical_History.Text = LanguadgeReady.generalMedicalHistory.GetText(LanguadgeReady.selectedlanguadge);
            Lbl_Alergies.Text = LanguadgeReady.allergiesIntolerances.GetText(LanguadgeReady.selectedlanguadge);
            Lbl_EnsureAllDrug.Text = LanguadgeReady.allergyWarning.GetText(LanguadgeReady.selectedlanguadge);
            BTN_Discard.Content = LanguadgeReady.discardChanges.GetText(LanguadgeReady.selectedlanguadge);
            BTN_Save.Content = LanguadgeReady.saveChanges.GetText(LanguadgeReady.selectedlanguadge);

        }
    }

}

