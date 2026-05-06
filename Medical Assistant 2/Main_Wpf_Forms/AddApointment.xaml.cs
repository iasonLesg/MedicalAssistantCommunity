using MedicalAssistantCommunity.Classes;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace MedicalAssistantCommunity
{
    /// <summary>
    /// Interaction logic for AddApointment.xaml
    /// </summary>
    public partial class AddApointment : Window
    {
        DateTime fromdate;
        DateTime todate;
        public bool Del = false;
        public Patient SelectedPatient=new Patient();
        public Appointment SelectedAppointment =new Appointment();
        public Appointment conflictingApp;
        public AddApointment()
        {
            InitializeComponent();
         
            AppDay.TextChanged += (s, e) => UpdateTimeline();
            AppYear.TextChanged += (s, e) => UpdateTimeline();
            AppMonth.SelectionChanged += (s, e) => UpdateTimeline();
            ComboDuration.SelectionChanged += (s, e) => UpdateTimeline();
            TxtHour.SelectionChanged += (s, e) => UpdateTimeline();
            TxtMinute.SelectionChanged += (s, e) => UpdateTimeline();
            ChangeLanguage();
            filltime();
            BTN_DeleteInterface.Visibility = Visibility.Collapsed;
        }

        public AddApointment(DateTime date)
        {
            InitializeComponent();
            filltime();
            AppDay.TextChanged += (s, e) => UpdateTimeline();
            AppYear.TextChanged += (s, e) => UpdateTimeline();
            AppMonth.SelectionChanged += (s, e) => UpdateTimeline();
            ComboDuration.SelectionChanged += (s, e) => UpdateTimeline();
            TxtHour.SelectionChanged += (s, e) => UpdateTimeline();
            TxtMinute.SelectionChanged += (s, e) => UpdateTimeline();
            ChangeLanguage();
            AppDay.Text = date.ToString("dd");
            AppYear.Text = date.ToString("yyyy");
            AppMonth.SelectedIndex = int.Parse(date.ToString("MM"))-1;
            BTN_DeleteInterface.Visibility = Visibility.Collapsed;
        }

        
        public AddApointment( Appointment _appointment) 
        {
            InitializeComponent();
           

            AppDay.TextChanged += (s, e) => UpdateTimeline();
            AppYear.TextChanged += (s, e) => UpdateTimeline();
            AppMonth.SelectionChanged += (s, e) => UpdateTimeline();
            ComboDuration.SelectionChanged += (s, e) => UpdateTimeline();
            TxtHour.SelectionChanged += (s, e) => UpdateTimeline();
            TxtMinute.SelectionChanged += (s, e) => UpdateTimeline();
            ChangeLanguage();
            SelectedAppointment = _appointment;
            AppDay.Text = _appointment.TimeScheduled.ToString("dd");
            AppYear.Text = _appointment.TimeScheduled.ToString("yyyy");
            AppMonth.SelectedIndex = int.Parse(_appointment.TimeScheduled.ToString("MM")) - 1;
            TxtHour.Text = _appointment.TimeScheduled.ToString("HH");
            TxtMinute.Text = _appointment.TimeScheduled.ToString("mm");
            SelectedAppointment.ID = _appointment.ID;
            TxtPatientSearch.Text = _appointment.Name;
            TxtReason.Text = _appointment.AppointmentReview;
            SelectedAppointment.PatientID = _appointment.PatientID;
            BtnSchedule.Content = LanguadgeReady.editAppointment.GetText(LanguadgeReady.selectedlanguadge);
            if (SelectedAppointment.PatientID >= 0) {
                LblSelectedPatientName.Text = _appointment.Name;
                TxtPatientSearch.Visibility = Visibility.Collapsed;
                SelectedPatientOverlay.Visibility = Visibility.Visible;
                PatientResultsPopup.IsOpen = false;
            }

            BTN_DeleteInterface.Visibility = Visibility.Visible;
        }
         
        private void ChangeLanguage() {
            AppMonth.Items[0] = LanguadgeReady.january.GetText(LanguadgeReady.selectedlanguadge);
            AppMonth.Items[1] = LanguadgeReady.february.GetText(LanguadgeReady.selectedlanguadge);
            AppMonth.Items[2] = LanguadgeReady.march.GetText(LanguadgeReady.selectedlanguadge);
            AppMonth.Items[3] = LanguadgeReady.april.GetText(LanguadgeReady.selectedlanguadge);
            AppMonth.Items[4] = LanguadgeReady.may.GetText(LanguadgeReady.selectedlanguadge);
            AppMonth.Items[5] = LanguadgeReady.june.GetText(LanguadgeReady.selectedlanguadge);
            AppMonth.Items[6] = LanguadgeReady.july.GetText(LanguadgeReady.selectedlanguadge);
            AppMonth.Items[7] = LanguadgeReady.august.GetText(LanguadgeReady.selectedlanguadge);
            AppMonth.Items[8] = LanguadgeReady.september.GetText(LanguadgeReady.selectedlanguadge);
            AppMonth.Items[9] = LanguadgeReady.october.GetText(LanguadgeReady.selectedlanguadge);
            AppMonth.Items[10] = LanguadgeReady.november.GetText(LanguadgeReady.selectedlanguadge);
            AppMonth.Items[11] = LanguadgeReady.december.GetText(LanguadgeReady.selectedlanguadge);

            AppMonth.SelectedIndex = 0;


            ModeLabel.Text= LanguadgeReady.appointmentCaps.GetText(LanguadgeReady.selectedlanguadge);
            WindowTitle.Text = LanguadgeReady.scheduleNewVisit.GetText(LanguadgeReady.selectedlanguadge);
            LBL_SelectPatient.Text = LanguadgeReady.patientName.GetText(LanguadgeReady.selectedlanguadge);
            LBL_AppointmentDate.Text = LanguadgeReady.appointmentDate.GetText(LanguadgeReady.selectedlanguadge);
            LBL_Day.Text = LanguadgeReady.day.GetText(LanguadgeReady.selectedlanguadge);
            LBL_Month.Text = LanguadgeReady.month.GetText(LanguadgeReady.selectedlanguadge);
            LBL_Year.Text = LanguadgeReady.year.GetText(LanguadgeReady.selectedlanguadge);
            LBL_ApointmentTimeDur.Text = LanguadgeReady.appointmentTimeDuration.GetText(LanguadgeReady.selectedlanguadge);
            LBL_VisitReason.Text = LanguadgeReady.visitReason.GetText(LanguadgeReady.selectedlanguadge);
            LBL_AvailavilityCheck.Text = LanguadgeReady.availabilityCheck.GetText(LanguadgeReady.selectedlanguadge);
            LBL_DailyTimeline.Text = LanguadgeReady.dailyTimeline.GetText(LanguadgeReady.selectedlanguadge);
            BtnCancel.Content = LanguadgeReady.cancel.GetText(LanguadgeReady.selectedlanguadge);
            BtnSchedule.Content = LanguadgeReady.scheduleAppointment.GetText(LanguadgeReady.selectedlanguadge);
            ComboDuration.Items[0] = LanguadgeReady.oneHour.GetText(LanguadgeReady.selectedlanguadge);
            ComboDuration.Items[1] = LanguadgeReady.fortyFiveMin.GetText(LanguadgeReady.selectedlanguadge);
            ComboDuration.Items[2] = LanguadgeReady.thirtyMin.GetText(LanguadgeReady.selectedlanguadge);
            ComboDuration.Items[3] = LanguadgeReady.twentyMin.GetText(LanguadgeReady.selectedlanguadge);
            ComboDuration.Items[4] = LanguadgeReady.fifteenMin.GetText(LanguadgeReady.selectedlanguadge);
            ComboDuration.Items[5] = LanguadgeReady.tenMin.GetText(LanguadgeReady.selectedlanguadge);
            ComboDuration.SelectedIndex = 0;

            
            DeleteApointmentBtn.Text = LanguadgeReady.deleteAppointment.GetText(LanguadgeReady.selectedlanguadge);


            

        }

        private void filltime() {


            AppMonth.SelectedIndex = int.Parse(DateTime.Now.Month.ToString()) - 1;
            AppYear.Text = DateTime.Now.Year.ToString();
            AppDay.Text = DateTime.Now.Day.ToString();
            if (int.Parse(DateTime.Now.Minute.ToString()) <= 15)
            {
                TxtMinute.Text = "00";
                TxtHour.Text = DateTime.Now.Hour.ToString();
            }
            else if (int.Parse(DateTime.Now.Minute.ToString()) <= 45)
            {
                TxtMinute.Text = "30";
                TxtHour.Text = DateTime.Now.Hour.ToString();
            }
            else
            {

                TxtMinute.Text = "00";
                TxtHour.Text = (int.Parse(DateTime.Now.Hour.ToString()) + 1).ToString();
            }
        }
        private void TxtPatientSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string query = TxtPatientSearch.Text.ToLower();

            if (string.IsNullOrWhiteSpace(query))
            {
                PatientResultsPopup.IsOpen = false;
                return;
            }

            // Filter your static list from MainWindow
            var filtered = MainWindow.Patients
                .Where(p => p.Name.ToLower().Contains(query))
                .ToList();
          
            if (filtered.Any())
            {
                LstPatientResults.ItemsSource = filtered;
                PatientResultsPopup.IsOpen = true;
            }
            else
            {
                PatientResultsPopup.IsOpen = false;
            }
        }

        private void LstPatientResults_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LstPatientResults.SelectedItem is Patient selected)
            {
                SelectedPatient = selected;
              // Set the UI to "Locked" mode
              LblSelectedPatientName.Text = selected.Name;
                TxtPatientSearch.Visibility = Visibility.Collapsed;
                SelectedPatientOverlay.Visibility = Visibility.Visible;

                PatientResultsPopup.IsOpen = false;

                // You can now store 'selected' in a local variable like 'SelectedAppointmentPatient'
            }
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
        private void ClearSelection_Click(object sender, RoutedEventArgs e)
        {
            // Re-enable editing
            TxtPatientSearch.Visibility = Visibility.Visible;
            SelectedPatientOverlay.Visibility = Visibility.Collapsed;
            SelectedAppointment.PatientID = -1;
           TxtPatientSearch.Text = "";
            LstPatientResults.ItemsSource = "";
            SelectedPatient = new Patient();
            TxtPatientSearch.Focus();
        }

        private void TxtPatientSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            // Re-show results if user clicks back into text box
            if (!string.IsNullOrWhiteSpace(TxtPatientSearch.Text))
                PatientResultsPopup.IsOpen = true;
        }

        private void Schedule_Apointment_Click(object sender, RoutedEventArgs e)
        {
           
            if (ReadCardFinal())
            {
            
                this.DialogResult = true;
                this.Close();
            }
           
        }
        private void Cancel_Click(object sender, RoutedEventArgs e) {
        this.Close();
        }
        private void UpdateTimeline()
        {
            if (TimelineContainer == null) return;
            TimelineContainer.Children.Clear();
            if (CheckSchedule())

            {
                
                //StatusText.Text = $"Conflict: {conflictingApp.Name}";
                StatusText.Text = $"{LanguadgeReady.scheduleConflict.GetText(LanguadgeReady.selectedlanguadge)} {conflictingApp.Name}";
                StatusText.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E53E3E"));
                StatusText2.Text= $"{LanguadgeReady.unavailableFrom.GetText(LanguadgeReady.selectedlanguadge)}  {conflictingApp.TimeScheduled.ToString("HH:mm")} - {conflictingApp.TimeScheduled.AddMinutes(conflictingApp.ApointmentDuration).ToString("HH:mm")}";
            }
            else
            {
                StatusText.Text = LanguadgeReady.slotAvailable.GetText(LanguadgeReady.selectedlanguadge);
                StatusText.Foreground = (Brush)Application.Current.Resources["SecondaryColor"];
                StatusText2.Text = $" {LanguadgeReady.availableFrom.GetText(LanguadgeReady.selectedlanguadge)} {fromdate.ToString("HH:mm")} - {todate.ToString("HH:mm")}";
            }

            if (int.TryParse(AppDay.Text, out int d) &&
                int.TryParse(AppYear.Text, out int y) &&
                AppMonth.SelectedIndex != -1)
            {
                try
                {
                    DateTime selectedDate = new DateTime(y, AppMonth.SelectedIndex + 1, d);
                    bool isPast = selectedDate < DateTime.Today;

                    // 1. Determine Color and Text
                    // If past, use red (#E53E3E), otherwise use your SecondaryColor
                    Brush headerBrush = isPast
                        ? new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E53E3E"))
                        : (Brush)Application.Current.Resources["SecondaryColor"];

                    string headerText = isPast
                        ? LanguadgeReady.datePassedNotice.GetText(LanguadgeReady.selectedlanguadge)
                        : LanguadgeReady.GetDayLanguageText(selectedDate);

                    // 2. Create the Header
                    Border header = new Border
                    {
                        Background = headerBrush,
                        Padding = new Thickness(10),
                        CornerRadius = new CornerRadius(8),
                        Margin = new Thickness(0, 0, 0, 10)
                    };
                    header.Child = new TextBlock
                    {
                        Text = headerText,
                        Foreground = Brushes.White,
                        FontWeight = FontWeights.Bold,
                        HorizontalAlignment = HorizontalAlignment.Center
                    };
                    TimelineContainer.Children.Add(header);

                    // 3. Only show appointments if the date is valid/future (optional)
                    // Or show them anyway so the user can see what happened that day:
                    var todaysApps = MainWindow.Appointments
                        .Where(a => a.TimeScheduled.Date == selectedDate.Date)
                        .OrderBy(a => a.TimeScheduled);

                    foreach (var app in todaysApps)
                    {
                        TimelineContainer.Children.Add(CreateAppointmentCard(app));
                    }

                    if (!todaysApps.Any())
                    {
                        TimelineContainer.Children.Add(new TextBlock
                        {
                            Text = LanguadgeReady.noAppointments.GetText(LanguadgeReady.selectedlanguadge),
                            Foreground = Brushes.LightGray,
                            HorizontalAlignment = HorizontalAlignment.Center,
                            Margin = new Thickness(0, 20, 0, 0)
                        });
                    }
                   
                       
                        
                    


                }
                catch
                {
                    // This catches invalid dates like Feb 31st while typing
                }
            }
        }

        private UIElement CreateAppointmentCard(Appointment app)
        {
            Button card = new Button
            {
                Margin = new Thickness(0, 0, 0, 8),
                Padding = new Thickness(12),
                Background = Brushes.White,
                BorderBrush = new SolidColorBrush(Color.FromRgb(226, 232, 240)),
                BorderThickness = new Thickness(1),
                HorizontalContentAlignment = HorizontalAlignment.Left,
                Cursor = Cursors.Hand
            };

            // Apply rounded corners to the button
            card.Resources.Add(typeof(Border), new Style(typeof(Border))
            {
                Setters = { new Setter(Border.CornerRadiusProperty, new CornerRadius(10)) }
            });

            StackPanel content = new StackPanel();

            // Line 1: Time and Duration (e.g., "10:30 (45 min)")
            content.Children.Add(new TextBlock
            {
                Text = $"{app.TimeScheduled:HH:mm} ({app.ApointmentDuration} min)",
                FontSize = 11,
                FontWeight = FontWeights.Bold,
                Foreground = (Brush)Application.Current.Resources["SecondaryColor"]
            });

            // Line 2: Patient Name
            content.Children.Add(new TextBlock
            {
                Text = app.Name,
                FontSize = 13,
                FontWeight = FontWeights.SemiBold,
                Foreground = (Brush)Application.Current.Resources["TextDark"],
                Margin = new Thickness(0, 2, 0, 0),
                TextTrimming = TextTrimming.CharacterEllipsis // Prevents long names from breaking the UI
            });

            card.Content = content;

            // Optional: Add a click event to view details
            card.Click += (s, e) => {
                // You could show a detail popup here
            };

            return card;
        }

        private bool CheckSchedule()
        {
            try
            {
                int.TryParse(AppDay.Text, out int day);
                int.TryParse(AppYear.Text, out int year);
                int.TryParse(TxtHour.Text, out int hour);
                int.TryParse(TxtMinute.Text, out int minute);
                DateTime scheduledDate = new DateTime(year, AppMonth.SelectedIndex + 1, day, hour, minute, 0);
                int duration = 0;
                switch (ComboDuration.SelectedIndex) {
                    case 0:
                        duration = 60;
                        break;
                    case 1:
                        duration = 45;
                        break;
                    case 2:
                        duration = 30;
                        break;
                    case 3:
                        duration = 20;
                        break;
                    case 4:
                        duration = 15;
                        break;
                    case 5:
                        duration = 10;
                        break;
                    default:
                        duration = 60;
                        break;

                }
                DateTime newStart = scheduledDate;
                DateTime newEnd = scheduledDate.AddMinutes(duration);
                fromdate = newStart;
                todate=newEnd;
                foreach (var app in MainWindow.Appointments)
                {
                    if (app.ID != SelectedAppointment.ID) {
                        DateTime existingStart = app.TimeScheduled;
                        DateTime existingEnd = app.TimeScheduled.AddMinutes(app.ApointmentDuration);


                        // The Overlap Logic
                        if (newStart < existingEnd && newEnd > existingStart)
                        {
                            conflictingApp = app;
                            return true;
                        }
                    }
                    
                }



                return false;
            }
            catch (ArgumentOutOfRangeException)
            {
              
                return false;
            }
            catch (Exception ex)
            {
               
                return false;
            }
        }


        private bool ReadCardFinal()
        {
            try
            {
            
                if (string.IsNullOrEmpty(TxtPatientSearch.Text))
                {
                    CustomMessageBox.Show(LanguadgeReady.fillPatientNameFirst.GetText(LanguadgeReady.selectedlanguadge),this);
                    return false;
                }
                if (SelectedPatient == null || string.IsNullOrEmpty(SelectedPatient.Name))
                {
                    CustomMessageBox.Show(LanguadgeReady.patientNotRegistered.GetText(LanguadgeReady.selectedlanguadge), this);

                }

                // 2. Parse Date and Time components
                if (!int.TryParse(AppDay.Text, out int day) ||
                    !int.TryParse(AppYear.Text, out int year) ||
                    !int.TryParse(TxtHour.Text, out int hour) ||
                    !int.TryParse(TxtMinute.Text, out int minute) ||
                    AppMonth.SelectedIndex == -1)
                {
                    CustomMessageBox.Show(LanguadgeReady.numericBoxesError.GetText(LanguadgeReady.selectedlanguadge), this);
                    return false;
                }

                // 3. Create the DateTime object
                // This will throw an exception if the date is invalid (e.g., Feb 31st)
                DateTime scheduledDate = new DateTime(year, AppMonth.SelectedIndex + 1, day, hour, minute, 0);
                int duration = 0;
                // 4. Get Duration from ComboBox Tag
                switch (ComboDuration.SelectedIndex)
                {
                    case 0:
                        duration = 60;
                        break;
                    case 1:
                        duration = 45;
                        break;
                    case 2:
                        duration = 30;
                        break;
                    case 3:
                        duration = 20;
                        break;
                    case 4:
                        duration = 15;
                        break;
                    case 5:
                        duration = 10;
                        break;
                    default:
                        CustomMessageBox.Show(LanguadgeReady.selectDuration.GetText(LanguadgeReady.selectedlanguadge), this);
                        return false;
                        break;

                }
                
            
         
            
               
                SelectedAppointment.Name = TxtPatientSearch.Text;
                SelectedAppointment.AppointmentReview = TxtReason.Text;
                SelectedAppointment.TimeScheduled = scheduledDate;
                SelectedAppointment.ApointmentDuration = duration;
                SelectedAppointment.AppointmentReview = TxtReason.Text;
                if (SelectedPatient != null)
                {
                    if (SelectedPatient.Name != "")
                    {
                        SelectedAppointment.Name = SelectedPatient.Name;
                        SelectedAppointment.PatientID = SelectedPatient.ID;

                    }


                }

                return true;
            }
            catch (ArgumentOutOfRangeException)
            {
                CustomMessageBox.Show(LanguadgeReady.invalidDate.GetText(LanguadgeReady.selectedlanguadge), this);
                return false;
            }
            catch (Exception ex)
            {
               
                return false;
            }
        }
       
    }
}