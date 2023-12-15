using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Project
{
    public partial class TeacherForm : Form
    {
        private const string ConnectionString = "Data Source=LAPTOP-TT07MONP\\SQLEXPRESS;Initial Catalog=Pr;Integrated Security=True";
        private string username; // Переменная для хранения имени пользователя
        private int teacherId; // Переменная для хранения TeacherID текущего пользователя

        public TeacherForm(string username)
        {
            InitializeComponent();
            this.username = username;

            // Получение TeacherID при инициализации формы
            this.teacherId = 1;

            // Вызов метода для просмотра студентов, выбравших тему преподавателя
            ViewStudentsByTeacher();
        }

        private int GetTeacherIdByUsername()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string getTeacherIdQuery = "SELECT TeacherID FROM Teachers WHERE UserID = (SELECT UserID FROM Users WHERE Username = @Username)";
                using (SqlCommand command = new SqlCommand(getTeacherIdQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    // Используем ExecuteScalar, так как ожидаем получить одно значение
                    object result = command.ExecuteScalar();

                    // Проверка на null
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        // Логика, если значение не найдено
                        // Можно вернуть 0 или другое значение по умолчанию
                        return 0;
                    }
                }
            }
        }


        private void ViewStudentsByTeacher()
        {
            dataGridViewStudents.Columns.Clear();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string getStudentsQuery = "SELECT Students.StudentID, Students.FullName, Students.Faculty, Students.GroupName, Topics.TopicTitle, Grades.ExamGrade, Grades.DefenseGrade " +
                                         "FROM Students " +
                                         "JOIN Topics ON Students.TopicID = Topics.TopicID " +
                                         "LEFT JOIN Grades ON Students.StudentID = Grades.StudentID " +
                                         "WHERE Topics.TeacherID = @TeacherID";

                using (SqlCommand command = new SqlCommand(getStudentsQuery, connection))
                {
                    command.Parameters.AddWithValue("@TeacherID", teacherId);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewStudents.DataSource = dataTable;
                }
            }

            // Разрешение редактирования для всех столбцов, кроме StudentID и FullName
            foreach (DataGridViewColumn column in dataGridViewStudents.Columns)
            {
                if (column.Name != "StudentID" && column.Name != "FullName")
                {
                    column.ReadOnly = false;
                }
            }
        }

        private void UpdateGradesInDatabase()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                foreach (DataGridViewRow row in dataGridViewStudents.Rows)
                {
                    int studentId = Convert.ToInt32(row.Cells["StudentID"].Value);
                    int examGrade = Convert.ToInt32(row.Cells["ExamGrade"].Value);
                    int defenseGrade = Convert.ToInt32(row.Cells["DefenseGrade"].Value);

                    string updateGradesQuery = "UPDATE Grades SET ExamGrade = @ExamGrade, DefenseGrade = @DefenseGrade " +
                                               "WHERE StudentID = @StudentID";

                    using (SqlCommand command = new SqlCommand(updateGradesQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ExamGrade", examGrade);
                        command.Parameters.AddWithValue("@DefenseGrade", defenseGrade);
                        command.Parameters.AddWithValue("@StudentID", studentId);

                        command.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Изменения сохранены в базе данных.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateGradesInDatabase();
        }
    }
}
