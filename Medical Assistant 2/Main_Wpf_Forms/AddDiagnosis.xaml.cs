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
    /// Interaction logic for AddDiagnosis.xaml
    /// </summary>
    public partial class AddDiagnosis : Window
    {
        public bool Del = false;
        public Diagnosis Data = new  Diagnosis();
        public AddDiagnosis()
        {
            InitializeComponent();
            BTN_DeleteInterface.Visibility = Visibility.Collapsed;
        }

        public AddDiagnosis(Diagnosis data)
        {
            InitializeComponent();
            GetLanguage();
            Data = data;
     
            // Load existing data into UI
            InitializeComponent();
            if (Data != null)
            {
                CurrentDiagnosis = Data;
                TxtDiagnosisText.Text = Data.DiagnosisText;
                LblTimeReleased.Text = LanguadgeReady.GetMonthLanguageText(Data.TimeReleased);
                LabelWindowTitle.Text = "Edit Diagnosis";
                if (Data.DiagnosisText != null)
                {
                    BTN_DeleteInterface.Visibility = Visibility.Visible;
                }
                else {
                    BTN_DeleteInterface.Visibility = Visibility.Collapsed;
                }
                
            }
            else
            {
                CurrentDiagnosis = new Diagnosis { TimeReleased = DateTime.Now, Active = true };
                LblTimeReleased.Text = DateTime.Now.ToShortDateString();
                BTN_DeleteInterface.Visibility = Visibility.Collapsed;
            }
            //if (isactive == false) { Label_Active_prescription.Text = LanguadgeReady.inactivePrescription.GetText(LanguadgeReady.selectedlanguadge); }


        }
        public Diagnosis CurrentDiagnosis { get; set; }

     

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            CurrentDiagnosis.DiagnosisText = TxtDiagnosisText.Text;
            // Logic to return to parent window or save to DB
            this.DialogResult = true;
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e) => this.Close();

        private void RadioButton_Click(object sender, RoutedEventArgs e) { /* Toggle Logic */ }
        private void GetLanguage() {
            Lbl_Diagnosis_Details.Text = LanguadgeReady.diagnosisDetails.GetText(LanguadgeReady.selectedlanguadge);
            LabelWindowTitle.Text = LanguadgeReady.clinicalDiagnosis.GetText(LanguadgeReady.selectedlanguadge);
            Lbl_Cond_Diagn.Text = LanguadgeReady.conditionDiagnosis.GetText(LanguadgeReady.selectedlanguadge);
            DeleteDiagnosisBtn.Text = LanguadgeReady.deleteDiagnosis.GetText(LanguadgeReady.selectedlanguadge);
            Lbl_TimeReleased.Text = LanguadgeReady.releaseDate.GetText(LanguadgeReady.selectedlanguadge);
            BTN_Cancel.Content = LanguadgeReady.cancel.GetText(LanguadgeReady.selectedlanguadge);
            BTN_Save.Content = LanguadgeReady.saveChanges.GetText(LanguadgeReady.selectedlanguadge);
           

        }


        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            // Create the custom delete window
            DeleteMessageBox deleteWin = new DeleteMessageBox(LanguadgeReady.deleteDiagnosisConfirm.GetText(LanguadgeReady.selectedlanguadge) );
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
