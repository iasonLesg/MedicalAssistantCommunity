using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Interaction logic for SystemSettings.xaml
    /// </summary>
    public partial class SystemSettings : Window
    {
        public bool PassSettings = false;
        public static string lan = "";
        private void SaveSettings_Click(object sender, RoutedEventArgs e)
        {
            if (LanguagePicker.SelectedItem is ComboBoxItem selectedItem)
            {

                try
                {
                    LanguadgeReady.selectedlanguadge = selectedItem.Tag.ToString();
                    lan = selectedItem.Tag.ToString();
                }
                catch { }
              
                FileManagment.SaveSettings();
                PassSettings = true;


                this.Close(); // Close the settings window
            }
        }

        private void CancelSettings_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // Simply close without saving
        }
        public SystemSettings()
        {
            InitializeComponent();
            PassSettings = false;
            ChangeLanguage();
           LanguagePicker.SelectedIndex = GetLanguadgeIndex(LanguadgeReady.selectedlanguadge);

           
        }

        private void ChangeLanguage()
        {

            ConfigurationLabel.Text = LanguadgeReady.configuration.GetText(LanguadgeReady.selectedlanguadge);
            SystemSettingsLabel.Text = LanguadgeReady.systemSettings.GetText(LanguadgeReady.selectedlanguadge);
            InterfaceLanguageLabel.Text = LanguadgeReady.interfaceLanguage.GetText(LanguadgeReady.selectedlanguadge);
            SelectLanguageLabel.Text = LanguadgeReady.selectLanguage.GetText(LanguadgeReady.selectedlanguadge);
            Settings_cancel_Label.Content = LanguadgeReady.cancel.GetText(LanguadgeReady.selectedlanguadge);
            Settings_Save_Label.Content = LanguadgeReady.saveChanges.GetText(LanguadgeReady.selectedlanguadge);


        }

       
        public int GetLanguadgeIndex(string selectedlanguadge)
        {
            int returnstring = 0;
            switch (selectedlanguadge)
            {
                case "en": returnstring = 0; break;
                case "el": returnstring = 1; break;
                case "es": returnstring = 2; break;
                case "zh": returnstring = 3; break;
                case "hi": returnstring = 4; break;
                case "ar": returnstring = 5; break;
                case "pt": returnstring = 6; break;
                case "bn": returnstring = 7; break;
                case "ru": returnstring = 8; break;
                case "jp": returnstring = 9; break;
                case "pa": returnstring = 10; break;
                case "de": returnstring = 11; break;
                case "jv": returnstring = 12; break;
                case "ko": returnstring = 13; break;
                case "fr": returnstring = 14; break;
                case "te": returnstring = 15; break;
                case "mr": returnstring = 16; break;
                case "tr": returnstring = 17; break;
                case "ta": returnstring = 18; break;
                case "vi": returnstring = 19; break;
                case "ur": returnstring = 20; break;
                case "it": returnstring = 21; break;
                case "th": returnstring = 22; break;
                case "gu": returnstring = 23; break;
                case "pl": returnstring = 24; break;
                case "uk": returnstring = 25; break;
                case "fa": returnstring = 26; break;
                case "ms": returnstring = 27; break;
                case "ro": returnstring = 28; break;
                case "nl": returnstring = 29; break;
                default:
                    returnstring = 0;
                    break;
            }

            return returnstring;
        }
    }
}
