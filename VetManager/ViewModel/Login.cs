using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VetManager.Model;
using VetManager.ViewModel.BaseClass;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

namespace VetManager.ViewModel
{
    class Login : PropertyChanger
    {
        DbInfo dbInfo = new DbInfo();

        public ICommand? LogInCommand { get; set; }
        private string email;
        private string password;
        private string warning;

        public string Email
        {
            get => email;
            set => SetField(ref email, value, nameof(Email));
        }

        public string Password
        {
            get => password;
            set => SetField(ref password, value, nameof(Password));
        }

        public string Warning
        {
            get => warning;
            set => SetField(ref warning, value, nameof(Warning));

        }



        public Login()
        {
            LogInCommand = new RelayCommand(LogIn, CanLogIn);
        }

        private bool CanLogIn(object obj)
        {
            return (!string.IsNullOrWhiteSpace(email) &&
            !string.IsNullOrWhiteSpace(password));
        }

        private void LogIn(object obj)
        {
            Debug.WriteLine("guzik działa");

            try
            {
                using (MySqlConnection connection = new MySqlConnection(dbInfo.connector))
                {
                    connection.Open();
                    Debug.WriteLine("Udane połączenie z bazą");

                    string query = $"Select email, password FROM users WHERE email = @email";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@email", this.email);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        
                        if (reader.Read())
                        {
                            string dbmail = reader.GetString("email");
                            string dbpassword = reader.GetString("password");

                            if (dbmail == email && dbpassword == password)
                            {
                                Debug.WriteLine("Dane poprawne, Logowanie");
                                Warning = "";
                                connection.Close();
                            }
                            else
                            {
                                Debug.WriteLine("Dane nie poprawne");
                                Warning = "Nie poprawne dane logowania";
                                connection.Close();
                            }

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
        }

    }
}
