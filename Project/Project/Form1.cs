using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        private const int MaxFailedAttempts = 2;
        private int failedLoginAttempts = 0;

        public class DatabaseManager
        {
            private const string ConnectionString = "Data Source=LAPTOP-TT07MONP\\SQLEXPRESS;Initial Catalog=Pr;Integrated Security=True";

            public static string CheckCredentials(string username, string password, out bool success)
            {
                success = false;

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT Role, UserID FROM Users WHERE Username = @Username AND PasswordHash = @PasswordHash";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@PasswordHash", password);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows && reader.Read())
                        {
                            success = true;
                            int userID = reader.GetInt32(reader.GetOrdinal("UserID"));
                            string role = reader.GetString(reader.GetOrdinal("Role"));

                            // Запись в историю входа
                            LogLoginHistory(userID, true);

                            return role;
                        }
                        else
                        {
                            // Запись в историю входа для неудачной попытки
                            LogLoginHistory(0, false);
                        }
                    }
                }

                return null;
            }

            public static void LogLoginHistory(int userID, bool success)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO LoginHistory ( LoginTime, Success) VALUES ( @LoginTime, @Success)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LoginTime", DateTime.Now); 
                        command.Parameters.AddWithValue("@Success", success);

                        

                        command.CommandText = query;

                        command.ExecuteNonQuery();
                    }
                }
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (failedLoginAttempts >= MaxFailedAttempts)
            {
                MessageBox.Show("Слишком много неудачных попыток входа. Повторите позже.");
                return;
            }

            string username = textBox1.Text;
            string password = textBox2.Text;

            bool success;
            string role = DatabaseManager.CheckCredentials(username, password, out success);

            if (success)
            {
                MessageBox.Show($"Вход выполнен успешно! Роль: {role}");

                switch (role)
                {
                    case "Admin":
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                        break;

                    case "Student":
                        UserForm userForm = new UserForm(username);
                        userForm.Show();
                        break;
                    case "Teacher":
                        TeacherForm TeacherForm = new TeacherForm(username);
                        TeacherForm.Show();
                        break;
                   
                    default:
                        MessageBox.Show("Неизвестная роль.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Ошибка входа. Пожалуйста, проверьте учетные данные.");

                // Увеличиваем счетчик неудачных попыток
                failedLoginAttempts++;

                // Если достигнут лимит, показываем CAPTCHA
                if (failedLoginAttempts == MaxFailedAttempts)
                {
                    ShowCaptcha();
                }
                else
                {
                  
                    DatabaseManager.LogLoginHistory(0, false);
                }
            }
        }

        private void ShowCaptcha()
        {
            CaptchaForm captchaForm = new CaptchaForm();
            DialogResult result = captchaForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // CAPTCHA успешно введена, сбрасываем счетчик неудачных попыток
                failedLoginAttempts = 0;
            }
            else
            {
                // Пользователь не ввел CAPTCHA, блокируем вход
                MessageBox.Show("Необходимо ввести корректную CAPTCHA. Приложение будет закрыто.");
                Application.Exit();
            }
        }
    }
}
