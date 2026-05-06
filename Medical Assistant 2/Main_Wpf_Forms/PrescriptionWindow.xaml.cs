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
    /// <summary>
    /// Interaction logic for PrescriptionWindow.xaml
    /// </summary>
    public partial class PrescriptionWindow : Window
    {
        public bool Del = false;
        private Prescription _data;
        private bool isactive=true;
        private void getlanguage() {
            Label_PRESCRIPTION_DETAILS.Text = LanguadgeReady.prescriptionDetails.GetText(LanguadgeReady.selectedlanguadge);
            LabelWindowTitle.Text =LanguadgeReady.issuePrescription.GetText(LanguadgeReady.selectedlanguadge);
            Label_Dosage_Instruction.Text = LanguadgeReady.dosageInstructions.GetText(LanguadgeReady.selectedlanguadge);
            Label_Medication_Name.Text = LanguadgeReady.medicationName.GetText(LanguadgeReady.selectedlanguadge);
            Label_Release_Date.Text = LanguadgeReady.releaseDate.GetText(LanguadgeReady.selectedlanguadge);
            BTN_Cancel_Prescription.Content= LanguadgeReady.cancel.GetText(LanguadgeReady.selectedlanguadge);
            BTN_Save_Prescription.Content= LanguadgeReady.saveChanges.GetText(LanguadgeReady.selectedlanguadge);
            Label_Active_prescription.Text = LanguadgeReady.activePrescription.GetText(LanguadgeReady.selectedlanguadge);
            BtnDelPRescription.Text= LanguadgeReady.deletePrescription.GetText(LanguadgeReady.selectedlanguadge);
            //rb_Active.Content = LanguadgeReady.active.GetText(LanguadgeReady.selectedlanguadge);

        }
        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton rb) {
                if (isactive == true) { rb.IsChecked = false; isactive = false; Label_Active_prescription.Text = LanguadgeReady.inactivePrescription.GetText(LanguadgeReady.selectedlanguadge); }
                else { rb.IsChecked = true; isactive = true; Label_Active_prescription.Text = LanguadgeReady.activePrescription.GetText(LanguadgeReady.selectedlanguadge); }
            
            }

          
        }
        public PrescriptionWindow(Prescription data)
        {
            InitializeComponent();
            getlanguage();
            _data = data;
            
            // Load existing data into UI
            TxtPrescriptionName.Text = _data.PrescriptionName;
            TxtDetails.Text = _data.PrescriptionDetails;
            //_data.TimeReleased.ToString("dd MMMM yyyy")
            LblReleaseDate.Text = LanguadgeReady.GetMonthLanguageText(_data.TimeReleased);
            isactive = _data.Active;
            rb_Active.IsChecked = isactive;

            if (!string.IsNullOrEmpty(_data.PrescriptionName))
            {
                LabelWindowTitle.Text = LanguadgeReady.editPrescription.GetText(LanguadgeReady.selectedlanguadge); DeleteBtn.Visibility = Visibility.Visible;
            }
            else { DeleteBtn.Visibility = Visibility.Collapsed; }
            if (isactive == false) { Label_Active_prescription.Text = LanguadgeReady.inactivePrescription.GetText(LanguadgeReady.selectedlanguadge); }


        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtPrescriptionName.Text))
            {
                CustomMessageBox.Show(LanguadgeReady.enterMedicationName.GetText(LanguadgeReady.selectedlanguadge), this);
                return;
            }
            

            // Map UI back to object
            _data.PrescriptionName = TxtPrescriptionName.Text;
            _data.PrescriptionDetails = TxtDetails.Text;
            _data.Active= isactive;
         
            // TimeReleased is usually set when created, but you could update it here if needed

            this.DialogResult = true;
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            // Create the custom delete window
            DeleteMessageBox deleteWin = new DeleteMessageBox(LanguadgeReady.deletePrescriptionConfirm.GetText(LanguadgeReady.selectedlanguadge));
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
    }
}
