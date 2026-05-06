using System;
using System.Collections.Generic;
using System.IO;
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
using System.IO;

namespace MedicalAssistantCommunity
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
       
        private FileManagment fm = new FileManagment();
        private bool isFirstRun = false;

        public Login()
        {
            InitializeComponent();
            ChangeLanguage();
            CheckForExistingUsers();
        }

        private void CheckForExistingUsers()
        {
            // Path to %AppData%/MedicalAssistant2
            string folderPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MedicalAssistant2");

            // 1. If the main directory doesn't even exist, it's definitely the first run
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                SetToFirstRunMode();
                return;
            }

          
        }

        // Helper method to keep the code clean
        private void SetToFirstRunMode()
        {
            isFirstRun = true;
            TitleTxt.Text = LanguadgeReady.createAccount.GetText(LanguadgeReady.selectedlanguadge);
            SubTitleTxt.Text = LanguadgeReady.setupCredentials.GetText(LanguadgeReady.selectedlanguadge);
            WarningBox.Visibility = Visibility.Visible;
            MainBtn.Content = LanguadgeReady.createInitialize.GetText(LanguadgeReady.selectedlanguadge);
        }

        private void ChangeLanguage() {
            LBL_Password.Text = LanguadgeReady.password.GetText(LanguadgeReady.selectedlanguadge);
            LBL_Username.Text = LanguadgeReady.username.GetText(LanguadgeReady.selectedlanguadge);
            BTN_EXIT.Content = LanguadgeReady.exitApplication.GetText(LanguadgeReady.selectedlanguadge);
            LBL_Important.Text = LanguadgeReady.important.GetText(LanguadgeReady.selectedlanguadge);
            LBL_LostText.Text = LanguadgeReady.passwordWarning.GetText(LanguadgeReady.selectedlanguadge);
            string folderPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MedicalAssistant2");
            Lbl_Lng.Text = LanguadgeReady.LngSub.GetText(LanguadgeReady.selectedlanguadge).ToUpper();
            // 2. Check for subdirectories (which represent usernames)
            string[] userFolders = Directory.GetDirectories(folderPath);

            if (userFolders.Length == 0)
            {
                SetToFirstRunMode();
            }
            else
            {

                // Users exist, proceed to normal Login mode
                isFirstRun = false;
                TitleTxt.Text = LanguadgeReady.welcomeBack.GetText(LanguadgeReady.selectedlanguadge);
                SubTitleTxt.Text = LanguadgeReady.loginAccess.GetText(LanguadgeReady.selectedlanguadge);
                WarningBox.Visibility = Visibility.Collapsed;
                MainBtn.Content = LanguadgeReady.login.GetText(LanguadgeReady.selectedlanguadge);
            }


        }
        private void ChangeLanguadge_click(object sender, RoutedEventArgs e) {
            SystemSettings settingsWindow = new SystemSettings();




            settingsWindow.Owner = this; // Centers it relative to MainWindow
            settingsWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            settingsWindow.ShowDialog();
            if (settingsWindow.PassSettings) { ChangeLanguage();  }

        }
        private void MainBtn_Click(object sender, RoutedEventArgs e)
        {
            string user = UsernameInput.Text;
            string pass = PasswordInput.Password;
            FileManagment.username = user;
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                CustomMessageBox.Show(LanguadgeReady.fillAllFields.GetText(LanguadgeReady.selectedlanguadge), this);
                return;
            }

           

            if (isFirstRun)
            {
               
                
                fm.InitializeAllData( pass);
                CustomMessageBox.Show(LanguadgeReady.accountCreated.GetText(LanguadgeReady.selectedlanguadge), this);
                Proceed(user, pass);
            }
            else
            {
                try
                {
                    // Attempt decryption as a password check
                    fm.LoadAllData(pass);
                    if (MainWindow.Patients != null)
                    {
                        Proceed(user, pass);
                    }
                    else
                    {
                        CustomMessageBox.Show(LanguadgeReady.invalidUsername.GetText(LanguadgeReady.selectedlanguadge), this);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    CustomMessageBox.Show(LanguadgeReady.invalidPassword.GetText(LanguadgeReady.selectedlanguadge), this);
                }
                catch (Exception)
                {
                    CustomMessageBox.Show(LanguadgeReady.usernameNotFound.GetText(LanguadgeReady.selectedlanguadge), this);
                }
            }
        }

        private void Proceed(string user, string pass)
        {
            // Pass the username/password to MainWindow constructor
            MainWindow main = new MainWindow(user, pass);
            main.Show();
            this.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
