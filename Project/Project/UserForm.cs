using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project
{
    public partial class UserForm : Form
    {
        private string username; 
        private int userId; 

        private const string ConnectionString = "Data Source=LAPTOP-TT07MONP\\SQLEXPRESS;Initial Catalog=Pr;Integrated Security=True";

        public UserForm(string username)
        {
            InitializeComponent();
            this.username = username;

          
            this.userId = GetUserIdByUsername();

          
            LoadUserData();
        }

        private int GetUserIdByUsername()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string getUserIdQuery = "SELECT UserID FROM Users WHERE Username = @Username";
                using (SqlCommand command = new SqlCommand(getUserIdQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                  
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        private void LoadUserData()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string getUserInfoQuery = "SELECT FullName, Faculty, GroupName FROM Students WHERE UserID = @UserID";
                using (SqlCommand command = new SqlCommand(getUserInfoQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string fullName = reader["FullName"].ToString();
                            string faculty = reader["Faculty"].ToString();
                            string groupName = reader["GroupName"].ToString();

                            textBoxFullName.Text = fullName;
                            textBoxFaculty.Text = faculty;
                            textBoxGroupName.Text = groupName;

                            
                            LoadDissertationTopic();
                            LoadExamAndDefenseGrades();
                        }
                    }
                }
            }
        }

        private void LoadDissertationTopic()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

               
                string getTopicQuery = "SELECT TopicTitle FROM Topics WHERE TopicID = (SELECT TopicID FROM Students WHERE UserID = @UserID)";
                using (SqlCommand command = new SqlCommand(getTopicQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string topicTitle = reader["TopicTitle"].ToString();

                           
                            labelTopic.Text = $"Тема : {topicTitle}";
                        }
                        else
                        {
                           
                            labelTopic.Text = "тема не выбрана";
                        }
                    }
                }
            }
        }


        private void LoadExamAndDefenseGrades()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string getGradesQuery = "SELECT ExamGrade, DefenseGrade FROM Grades WHERE StudentID = (SELECT StudentID FROM Students WHERE UserID = @UserID)";
                using (SqlCommand command = new SqlCommand(getGradesQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int examGrade = Convert.ToInt32(reader["ExamGrade"]);
                            int defenseGrade = Convert.ToInt32(reader["DefenseGrade"]);

                          
                            labelExamGrade.Text = $"Оценка по экзамену: {examGrade}";
                            labelDefenseGrade.Text = $"Защита диплома: {defenseGrade}";
                        }
                        else
                        {

                            labelExamGrade.Text = "нет оценки";
                            labelDefenseGrade.Text = "нет оценки";
                        }
                    }
                }
            }
        }

    }
}
