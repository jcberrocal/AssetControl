using System;
using System.Configuration;
using AssetControl.Logic;

namespace AssetControl.Classes
{
    internal class AppConfiguration
    {
        private static AppConfiguration _instance;

        public static AppConfiguration Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AppConfiguration();
                }
                return _instance;
            }
        }

        public string AppUser { get; set; }
        public string Server { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }
        public string DataBase { get; set; }
        public string Parish {  get; set; }
        public string Address { get; set; }

        private AppConfiguration()
        {
            LoadAppSettings();
        }

        public void LoadAppSettings()
        {
            AppUser = ConfigurationManager.AppSettings["AppUser"] ?? "admin";
            Server = ConfigurationManager.AppSettings["Server"] ?? "localhost";
            User = !string.IsNullOrEmpty(ConfigurationManager.AppSettings["User"]) ?
                Encryptor.DecryptWord(ConfigurationManager.AppSettings["User"]) : string.Empty;
            Password = !string.IsNullOrEmpty(ConfigurationManager.AppSettings["Password"]) ?
                Encryptor.DecryptWord(ConfigurationManager.AppSettings["Password"]) : string.Empty;
            Port = Convert.ToInt32(ConfigurationManager.AppSettings["Port"]);
            DataBase = !string.IsNullOrEmpty(ConfigurationManager.AppSettings["DataBase"]) ?
                Encryptor.DecryptWord(ConfigurationManager.AppSettings["DataBase"]) : string.Empty;
            Parish = ConfigurationManager.AppSettings["Parish"] ?? string.Empty;
            Address = ConfigurationManager.AppSettings["Address"] ?? string.Empty;
        }

        public void SaveAppSettings()
        {
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["AppUser"].Value = AppUser;
                config.AppSettings.Settings["Server"].Value = Server;
                config.AppSettings.Settings["User"].Value = Encryptor.EncryptWord(User);
                config.AppSettings.Settings["Password"].Value = Encryptor.EncryptWord(Password);
                config.AppSettings.Settings["Port"].Value = Port.ToString();
                config.AppSettings.Settings["DataBase"].Value = Encryptor.EncryptWord(DataBase);
                config.AppSettings.Settings["Parish"].Value = Parish;
                config.AppSettings.Settings["Address"].Value = Address;
                
                config.Save(ConfigurationSaveMode.Modified);

                ReloadAppSettings();
            }
            catch (Exception ex)
            {
                //TRADUCE
                throw new Exception($"Ucurrió un error al guardar la configuración: {ex.Message}");   
            }
        }

        public void ReloadAppSettings()
        {
            ConfigurationManager.RefreshSection("appSettings");
            LoadAppSettings();
        }
    }
}
