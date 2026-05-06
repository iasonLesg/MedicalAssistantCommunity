using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Security.Cryptography;
using System.Text;
using MedicalAssistantCommunity.Classes;

namespace MedicalAssistantCommunity
{
    // A wrapper to bundle everything into one JSON object
    public class MedicalDataContainer
    {
        public  List<Patient> Patients { get; set; } = new();
        public  List<Appointment> Appointments { get; set; } = new();


    }

    public class FileManagment
    {


        public static string username = "";
        private readonly static  string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MedicalAssistant2");
        private static string PatPath => Path.Combine(UserFolder, username + "_Data.json");
        private static string UserFolder => Path.Combine(folderPath, username);
        private static string SettPath => Path.Combine(UserFolder, username+"_Settings.json");

        public FileManagment()
        {
            if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);
        }
        public void EnsureUserFolderExists()
        {
            if (!string.IsNullOrEmpty(username) && !Directory.Exists(UserFolder))
            {
                Directory.CreateDirectory(UserFolder);
            }
        }
        public void InitializeAllData(string password)
        {
            // create the directories and save files
            EnsureUserFolderExists();
            var initialData = new MedicalDataContainer();
            SaveAllData( password);
            SaveSettings();
        }


     

        public static void SaveAllData( string password)
        {
            // Save all patiend and subscription data
            MedicalDataContainer data=new MedicalDataContainer();
            data.Patients = MainWindow.Patients;
            data.Appointments = MainWindow.Appointments;
            string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            string encrypted = PatEncryption.Encrypt(json, password);
            File.WriteAllText(PatPath, encrypted);

        }

        public void LoadAllData(string password)
        {
            LoadSettings();
            if (!File.Exists(PatPath)) ;

            string encrypted = File.ReadAllText(PatPath);
            string decrypted = PatEncryption.Decrypt(encrypted, password);

            if (decrypted == null) throw new UnauthorizedAccessException(); // Password wrong

            try
            {
                MedicalDataContainer data = JsonSerializer.Deserialize<MedicalDataContainer>(decrypted);
                MainWindow.Patients = data.Patients;
                MainWindow.Appointments = data.Appointments;
            }
            catch (Exception ex) { }
           
        }


        public static void SaveSettings()
        {
            AppSettings settings = new AppSettings();
            settings.Language = LanguadgeReady.selectedlanguadge;
            string json = JsonSerializer.Serialize(settings);
            File.WriteAllText(SettPath, json);
        }

        public void LoadSettings()
        {
            if (File.Exists(SettPath) && SystemSettings.lan != "") {
                LanguadgeReady.selectedlanguadge = SystemSettings.lan;
                SystemSettings.lan = "";
                SaveSettings();
            }
            else if (File.Exists(SettPath))
            {
                string json = File.ReadAllText(SettPath);
                AppSettings savedsetting = JsonSerializer.Deserialize<AppSettings>(json) ?? new AppSettings();
                LanguadgeReady.selectedlanguadge = savedsetting.Language;

            }
           
        }

     
    }





    public static class PatEncryption
    {
        private static readonly byte[] Salt = Encoding.ASCII.GetBytes(FileManagment.username);

        public static string Encrypt(string plainText, string password)
        {
            using Aes aes = Aes.Create();
            var key = new Rfc2898DeriveBytes(password, Salt, 10000, HashAlgorithmName.SHA256);
            aes.Key = key.GetBytes(32);
            aes.IV = key.GetBytes(16);

            using MemoryStream ms = new();
            using (CryptoStream cs = new(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
            {
                using (StreamWriter sw = new(cs))
                {
                    sw.Write(plainText);
                }
            }
            return Convert.ToBase64String(ms.ToArray());
        }

        public static string Decrypt(string cipherText, string password)
        {
            try
            {
                using Aes aes = Aes.Create();
                var key = new Rfc2898DeriveBytes(password, Salt, 10000, HashAlgorithmName.SHA256);
                aes.Key = key.GetBytes(32);
                aes.IV = key.GetBytes(16);

                using MemoryStream ms = new(Convert.FromBase64String(cipherText));
                using CryptoStream cs = new(ms, aes.CreateDecryptor(), CryptoStreamMode.Read);
                using StreamReader sr = new(cs);
                return sr.ReadToEnd();
            }
            catch { return null; }
        }
    }
}