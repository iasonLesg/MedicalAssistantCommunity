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
    /// Interaction logic for DeleteMessageBox.xaml
    /// </summary>
    public partial class DeleteMessageBox : Window
    {
        public DeleteMessageBox(string message)
        {
            InitializeComponent();
            GetLang();
            MessageText.Text = message;
        }

        // Static helper to call it easily
        public static bool Show(string message, Window owner)
        {
            var msg = new DeleteMessageBox(message);
            msg.Owner = owner;
            return msg.ShowDialog() ?? false;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
        private void GetLang() {
            lBL_Subtitle.Text = LanguadgeReady.actionCannotBeUndone.GetText(LanguadgeReady.selectedlanguadge);
            BTN_Cancel.Content = LanguadgeReady.cancel.GetText(LanguadgeReady.selectedlanguadge);
            BTN_Delete.Content = LanguadgeReady.deleteText.GetText(LanguadgeReady.selectedlanguadge);


        }
    }

}
