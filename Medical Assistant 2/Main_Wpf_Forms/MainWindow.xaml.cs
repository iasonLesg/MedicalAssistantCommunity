using MedicalAssistantCommunity.Classes;
using Microsoft.VisualBasic;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace MedicalAssistantCommunity
{
  
    public partial class MainWindow : Window
    {
        //UI
        //Mode selected:
        int numberofdays = 14;
        public enum SelectedMode { Patient, Appointment }
        public SelectedMode CurrentMode { get; set; } = SelectedMode.Patient;
        //Shown Username (bottom left):
        public string Username { get; set; }
        private string _currentUser;
        private string _currentPassword;

        //Backend:
        public static List<Patient> Patients = new List<Patient>();
        public static List<Appointment> Appointments = new List<Appointment>();
        public MainWindow()
        {

          
            InitializeComponent();
            ChangeLanguage();

            Username = "test";
            RefreshPatientList(Patients);
            // Tell the Window to look at "this" class for data bindings
            this.DataContext = this;

        }
        public MainWindow(string user, string pass)
        {
            InitializeComponent();
            _currentUser = user;
            _currentPassword = pass;

            // Update your UI with the username
            // (Assuming you have the binding we set up earlier)
            this.DataContext = new { Username = _currentUser };
     
            
            InitializeComponent();
            ChangeLanguage();

            Username = _currentUser;

            RefreshPatientList(Patients);
            // Tell the Window to look at "this" class for data bindings
            this.DataContext = this;
        }
       
       
        #region UI

        private void ModeChanged(object sender, RoutedEventArgs e)
        {
           //On click changed mode from patient to apointment and viseversa
            var rb = sender as RadioButton;
            if (rb != null && rb.IsChecked == true)
            {
                switch (rb.Tag.ToString()){
                    case "0":
                        ChangeMenuToPatient();
                        RefreshPatientList(Patients);
                        break;
                    case "1":
                        ChangeMenuApointment();
                        RefreshAppointmentCalendar(Appointments);
                        break;
                }
                 
            }

        }

        public void RefreshAppointmentCalendar(List<Appointment> appointments)
        {
            if (PatientDisplayArea != null) {

                if (PatientDisplayArea.Children != null) { 
                
                
                
          
            PatientDisplayArea.Children.Clear();
            PatientDisplayArea.Orientation = Orientation.Horizontal;
                    bool initial = true;
            for (int i = 0; i < numberofdays; i++)
            {
                DateTime dayDate = DateTime.Today.AddDays(i);
                var todaysApps = appointments.Where(a => a.TimeScheduled.Date == dayDate.Date)
                             .OrderBy(a => a.TimeScheduled);
                        // --- (Existing Day Column setup code here) ---
                        Brush Background2 = (Brush)Application.Current.Resources["SecondaryColor"];
                        if (initial) {
                            Background2 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00dff7"));
                        }


                StackPanel dayColumn = new StackPanel
                {
                    Width = 140, // Fixed width for each day column
                    Margin = new Thickness(5),
                    Background = new SolidColorBrush(Color.FromRgb(250, 251, 252))
                };

                // Day Header (e.g., "Mon 02")
                Border dayHeader = new Border
                {
                    Background = Background2,
                    Padding = new Thickness(5),
                    CornerRadius = new CornerRadius(5, 5, 0, 0)
                };
                        initial = false;

                  TextBlock txtDay = new TextBlock
                {
                    Text = LanguadgeReady.GetDayLanguageText(dayDate) ,

                    
                    Foreground = Brushes.White,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    FontWeight = FontWeights.Bold
                };
                dayHeader.Child = txtDay;
                dayColumn.Children.Add(dayHeader);

             

                foreach (var app in todaysApps)
                {
                    // Create a "Card" for the appointment
                    Button appCard = new Button
                    {
                        Margin = new Thickness(0, 5, 0, 0),
                        Padding = new Thickness(8),
                        Background = Brushes.White,
                        BorderBrush = new SolidColorBrush(Color.FromRgb(226, 232, 240)),
                        BorderThickness = new Thickness(1),
                        HorizontalContentAlignment = HorizontalAlignment.Left,
                        Cursor = Cursors.Hand
                    };

                    // Custom Style for the Card Content
                    StackPanel cardContent = new StackPanel();

                    TextBlock txtTime = new TextBlock
                    {
                        Text = app.TimeScheduled.ToString("HH:mm")+ " - "  +app.TimeScheduled.AddMinutes(app.ApointmentDuration).ToString("HH:mm"),
                        FontSize = 10,
                        Foreground = (Brush)Application.Current.Resources["SecondaryColor"],
                        FontWeight = FontWeights.Bold
                    };

                    TextBlock txtName = new TextBlock
                    {
                        Text = app.Name,
                        FontSize = 11,
                        Foreground = app.PatientID != -1
                            ? Brushes.Black
                            : Brushes.Gray,
                        FontWeight = app.PatientID != -1
                            ? FontWeights.Bold
                            : FontWeights.SemiBold,
                        TextTrimming = TextTrimming.CharacterEllipsis
                    };

                    cardContent.Children.Add(txtTime);
                    cardContent.Children.Add(txtName);
                    appCard.Content = cardContent;
                    appCard.Click += (s, e) =>
                    {
                        EditAppointment(app);
                    };
                           

                    dayColumn.Children.Add(appCard);
                }

                // --- NEW: Add Appointment Button at the bottom of the column ---
                Button addBtn = new Button
                {
                    Content = "+",
                    Margin = new Thickness(0, 10, 0, 5),
                    Height = 30,
                    Width = 30,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Background = Brushes.Transparent,
                    Foreground = (Brush)Application.Current.Resources["SecondaryColor"],
                    BorderBrush = (Brush)Application.Current.Resources["SecondaryColor"],
                    BorderThickness = new Thickness(1),
                    FontWeight = FontWeights.Bold,
                    FontSize = 18,
                    Cursor = Cursors.Hand,
                    // Attach the date to the button so the click knows which day we chose
                    Tag = dayDate
                };

                // Round the corners of this specific button
                addBtn.Resources.Add(typeof(Border), new Style(typeof(Border))
                {
                    Setters = { new Setter(Border.CornerRadiusProperty, new CornerRadius(15)) }
                });

                // Click Event
                addBtn.Click += (s, e) => {
                    DateTime selectedDate = (DateTime)((Button)s).Tag;
                    AddApointment AddApoint = new AddApointment(selectedDate);
                    AddApoint.Owner = this;
                    AddApoint.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                    if (AddApoint.ShowDialog() == true)
                    {
                        Appointments.Add(AddApoint.SelectedAppointment);

                        SaveRefresh();

                    }


                       
                    // Here you would open your "New Appointment" Window/Dialog
                };

                dayColumn.Children.Add(addBtn);
                PatientDisplayArea.Children.Add(dayColumn);
            }
        }

            }

        }

        public void EditAppointment(Appointment app)
        {
            AddApointment editWindow = new AddApointment(app);
            editWindow.Owner = this;
            editWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            editWindow.ShowDialog();
            if (editWindow.Del == true || editWindow.DialogResult==true)
            {
                // 1. Find the index of the old appointment in your main list
                int index = MainWindow.Appointments.IndexOf(app);
              
                if (index != -1)
                {
                    // 2. Replace the old object with the new one
                    MainWindow.Appointments[index] = editWindow.SelectedAppointment;
                }
                if (editWindow.Del)
                {
                    int id = 0;
                    List<Appointment> TempAppointments=new List<Appointment>();
                    foreach (Appointment apoint in MainWindow.Appointments) {
                        if (apoint.ID != index) {
                            TempAppointments.Add(apoint);
                            TempAppointments[TempAppointments.Count-1].ID= id;
                            id++;
                        }
                      
                    
                    }
                    MainWindow.Appointments = TempAppointments;
                }
                // 3. Save and refresh the UI
                SaveRefresh();
            }
        }
        public void RefreshPatientList(List<Patient> patients)
        {
            if (PatientDisplayArea != null) {
                if (PatientDisplayArea.Children != null)
                {
                    // 1. Clean the Grid/Panel
                    PatientDisplayArea.Children.Clear();

                    // 2. Fill it up with class items
                    foreach (var pt in patients)
                    {
                        // Create a StackPanel to hold Icon + Text vertically
                        StackPanel patientBox = new StackPanel
                        {
                            Margin = new Thickness(20),
                            Width = 90
                        };

                        // Create the Button with your custom Style
                        Button btn = new Button
                        {
                            Style = (Style)Application.Current.Resources["IconButtonStyle"],
                            Tag = pt // Store the whole patient object for later use
                        };

                        // Determine Color based on the Sex variable
                        switch (pt.Sex)
                        {
                            case 1:
                                btn.Foreground = (Brush)Application.Current.Resources["SecondaryColor"];
                                break;
                            case 2:
                                btn.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF69B4"));
                                break;
                            default:
                                btn.Foreground = (Brush)Application.Current.Resources["TextGrey"];
                                break;
                        }

                        // Attach the click event
                        btn.Click += PatientIcon_Click;

                        // Create the Name Label
                        TextBlock txtName = new TextBlock
                        {
                            Text = pt.Name,
                            HorizontalAlignment = HorizontalAlignment.Center,
                            Margin = new Thickness(0, 10, 0, 0),
                            FontSize = 13,
                            FontWeight = FontWeights.SemiBold,
                            Foreground = (Brush)Application.Current.Resources["TextDark"],
                            TextTrimming = TextTrimming.CharacterEllipsis // Adds "..." if name is too long
                        };

                        // Assemble the UI
                        patientBox.Children.Add(btn);
                        patientBox.Children.Add(txtName);

                        // Add to the Main Display Area
                        PatientDisplayArea.Children.Add(patientBox);
                    }
                }
            }
            
        }
        private void PatientIcon_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn && btn.Tag is Patient clickedPatient)
            {
                // Example: logic to open details
                //WindowMidTitle.Text = $"Profile: {clickedPatient.Name}";
                int index = clickedPatient.ID;
                AddPatientWindow EditPatientWin = new AddPatientWindow(Patients[index]);
                
                EditPatientWin.Owner = this;
                EditPatientWin.WindowStartupLocation = WindowStartupLocation.CenterOwner;

                EditPatientWin.ShowDialog();
                if (EditPatientWin.Del) {
                    
                    List<Patient> TempPatients = new List<Patient>();
                    int id = 0;
                    foreach (Patient pat in MainWindow.Patients) {
                        if (pat.ID != index) {

                            TempPatients.Add(pat);
                            TempPatients[TempPatients.Count-1].ID= id;
                            id++;


                        }
                    }
                    MainWindow.Patients = TempPatients;
                }
               
                SaveRefresh();

                WindowMidTitle.Text = LanguadgeReady.patientRegistry.GetText(LanguadgeReady.selectedlanguadge);
            }
        }
        private void SaveRefresh() {
            FileManagment.SaveAllData( _currentPassword);
            switch (CurrentMode) {
                case SelectedMode.Patient:
                    RefreshPatientList(Patients);
                    break;
                case SelectedMode.Appointment:
                    RefreshAppointmentCalendar(Appointments);
                    break;
            }
            
        }


        private void CalendarLength_Changed(object sender, RoutedEventArgs e) {

            switch (CalendarLengthPicker.SelectedIndex) {
                case 0:
                    numberofdays = 7;
                    break;
                case 1:
                    numberofdays = 14;
                    break;
                case 2:
                    numberofdays = 30;
                    break;
                case 3:
                    numberofdays = 90;
                    break;
            }
            RefreshAppointmentCalendar(Appointments);
        }
        private void OpenSettings_Click(object sender, RoutedEventArgs e)
        {
            // Create an instance of your settings window
            SystemSettings settingsWindow = new SystemSettings();
        
            


            settingsWindow.Owner = this; // Centers it relative to MainWindow
            settingsWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            settingsWindow.ShowDialog();
            if (settingsWindow.PassSettings) { ChangeLanguage(); SaveRefresh(); }
        }
        private void ChangeMenuToPatient() {
            if (WindowMidTitle != null) {
                WindowMidTitle.Text = LanguadgeReady.patientRegistry.GetText(LanguadgeReady.selectedlanguadge);
            }
            if (RegisterNew != null)
            {
                RegisterNew.Content = LanguadgeReady.registerPatient.GetText(LanguadgeReady.selectedlanguadge);
            }
            if (SearchBoxGrid != null && CalendarBorder!=null) {
                SearchBoxGrid.Visibility = Visibility.Visible;
                CalendarBorder.Visibility = Visibility.Collapsed;
            }
            

            CurrentMode = SelectedMode.Patient;
        }
        private void ChangeMenuApointment()
        {
            if (WindowMidTitle != null)
            {
                WindowMidTitle.Text = LanguadgeReady.scheduleAppointment.GetText(LanguadgeReady.selectedlanguadge);
            }
            if (RegisterNew != null)
            {
                RegisterNew.Content = LanguadgeReady.scheduleAppointment.GetText(LanguadgeReady.selectedlanguadge);
            }
            if (SearchBoxGrid != null && CalendarBorder != null)
            {
                SearchBoxGrid.Visibility = Visibility.Collapsed;
                CalendarBorder.Visibility= Visibility.Visible;
            }
            
            CurrentMode = SelectedMode.Appointment;

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            switch (CurrentMode) {
                case SelectedMode.Patient:
                    GetPatient();
                    break;
                case SelectedMode.Appointment:
                    GetApointment();
                    break;
            }
        }


        private void GetPatient() {
            //Open New Patient Window

            AddPatientWindow addPatientWin = new AddPatientWindow();

            addPatientWin.Owner = this;
            addPatientWin.WindowStartupLocation = WindowStartupLocation.CenterOwner;

            addPatientWin.ShowDialog();
            if (addPatientWin.DialogResult==true) {
                Patients.Add(addPatientWin.CurrentPatient);
              
                    SaveRefresh();
              
            }

        }
        private void GetApointment()
        {
            //Open New apointment Window
            AddApointment addApointmentWin = new AddApointment();

            addApointmentWin.Owner = this;
            addApointmentWin.WindowStartupLocation = WindowStartupLocation.CenterOwner;

            addApointmentWin.ShowDialog();
            if (addApointmentWin.DialogResult == true)
            {
                Appointments.Add(addApointmentWin.SelectedAppointment);

                SaveRefresh();

            }

        }
        #endregion



     

        private void SearchInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = SearchInput.Text;
            List<Patient> TempPatients=new List<Patient>(); 

            for (int i = 0; i < Patients.Count; i++) {

                if (Patients[i].Name.ToLower().Contains(searchText.ToLower()) || Patients[i].SocialSecurityNumber.ToString().ToLower().Contains(searchText.ToLower()) || Patients[i].PhoneNumber.ToString().ToLower().Contains(searchText.ToLower())) {
                    TempPatients.Add(Patients[i]);
                }
            
            }
            RefreshPatientList(TempPatients);


        }
        private void ChangeLanguage() {
            bool patientscheck = PatientsRadioBtn.IsChecked ?? false;
            bool appointmentscheck = AppointmentRadioBtn.IsChecked ?? false;
            LogoSubTitle.Text = LanguadgeReady.patientDataManagement.GetText(LanguadgeReady.selectedlanguadge);
            WindowMidTitle.Text = LanguadgeReady.patientRegistry.GetText(LanguadgeReady.selectedlanguadge);
            RegisterNew.Content = LanguadgeReady.registerPatient.GetText(LanguadgeReady.selectedlanguadge);
            AppointmentRadioBtn.Content = LanguadgeReady.appointments.GetText(LanguadgeReady.selectedlanguadge);
            PatientsRadioBtn.Content = LanguadgeReady.patients.GetText(LanguadgeReady.selectedlanguadge);
            CalendarDropDownLabel.Text = LanguadgeReady.viewRange.GetText(LanguadgeReady.selectedlanguadge);
            SearchPatientsLabel.Text= LanguadgeReady.searchPatients.GetText(LanguadgeReady.selectedlanguadge) +"...";
            LBL_SustemUser.Text = LanguadgeReady.communityUser.GetText(LanguadgeReady.selectedlanguadge);
            LBL_SystemOver.Text = LanguadgeReady.systemOverview.GetText(LanguadgeReady.selectedlanguadge);
            int select = CalendarLengthPicker.SelectedIndex;
            CalendarLengthPicker.Items[0] = "7 " +LanguadgeReady.days.GetText(LanguadgeReady.selectedlanguadge);
            CalendarLengthPicker.Items[1] = "14 " + LanguadgeReady.days.GetText(LanguadgeReady.selectedlanguadge);
            CalendarLengthPicker.Items[2] = "30 " + LanguadgeReady.days.GetText(LanguadgeReady.selectedlanguadge);
            CalendarLengthPicker.Items[3] = "90 " + LanguadgeReady.days.GetText(LanguadgeReady.selectedlanguadge);
            CalendarLengthPicker.SelectedIndex = select;
            PatientsRadioBtn.IsChecked = patientscheck;
            AppointmentRadioBtn.IsChecked = appointmentscheck;
            if (patientscheck) { CurrentMode = SelectedMode.Patient; }
            else { CurrentMode = SelectedMode.Appointment; }

        }
        
        
        


        public Patient SetNew(Patient InputPatient)
        {
            InputPatient.SocialSecurityNumber = 0;
            InputPatient.Name = "";
            InputPatient.ID = Patients.Count;
            InputPatient.Sex = (int)SexVals.Undefined;
            InputPatient.DateOfBirth = DateTime.Now;
            return InputPatient;
        }
        public Appointment SetNew(Appointment InputAppointment)
        {
           
            InputAppointment.Name = "";
            InputAppointment.ID = Appointments.Count;
            InputAppointment.TimeScheduled = DateTime.Now;
            return InputAppointment;
        }
        public Prescription SetNew(Prescription InputPrescription, Patient Patient, Appointment InputAppointment)
        {
            InputPrescription.ID = Patient.Prescriptions.Count;
            InputPrescription.TimeReleased = DateTime.Now;
            InputPrescription.PrescriptionName = "";
            InputPrescription.PrescriptionDetails = "";
            return InputPrescription;
        }


        public void ShowPatients() { 
        
        
        }

    }

}