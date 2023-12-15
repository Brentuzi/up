using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project
{
    public partial class AdminForm : Form
    {
        private const string ConnectionString = "Data Source=LAPTOP-TT07MONP\\SQLEXPRESS;Initial Catalog=Pr;Integrated Security=True";
        private SqlDataAdapter studentsAdapter, teachersAdapter, topicsAdapter;
        private DataTable studentsDataTable, teachersDataTable, topicsDataTable;
        private BindingSource studentsBindingSource, teachersBindingSource, topicsBindingSource;

        public AdminForm()
        {
            InitializeComponent();

            studentsBindingSource = new BindingSource();
            teachersBindingSource = new BindingSource();
            topicsBindingSource = new BindingSource();

            LoadStudents();
            LoadTeachers();
            LoadTopics();
        }

        private void LoadStudents()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string getStudentsQuery = "SELECT StudentID, FullName, Faculty, GroupName FROM Students";
                studentsAdapter = new SqlDataAdapter(getStudentsQuery, connection);
                studentsDataTable = new DataTable();
                studentsAdapter.Fill(studentsDataTable);

                studentsBindingSource.DataSource = studentsDataTable;
                dataGridViewStudents.DataSource = studentsBindingSource;

                dataGridViewStudents.Columns["StudentID"].HeaderText = "id студента";
                dataGridViewStudents.Columns["FullName"].HeaderText = "Фио";
                dataGridViewStudents.Columns["Faculty"].HeaderText = "Специальность";
                dataGridViewStudents.Columns["GroupName"].HeaderText = "Группа";

                dataGridViewStudents.ReadOnly = false;
            }
        }

        private void LoadTeachers()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string getTeachersQuery = "SELECT TeacherID, FullName, Department FROM Teachers";
                teachersAdapter = new SqlDataAdapter(getTeachersQuery, connection);
                teachersDataTable = new DataTable();
                teachersAdapter.Fill(teachersDataTable);

                teachersBindingSource.DataSource = teachersDataTable;
                dataGridViewTeachers.DataSource = teachersBindingSource;

                dataGridViewTeachers.Columns["TeacherID"].HeaderText = "Идентификатор учителя";
                dataGridViewTeachers.Columns["FullName"].HeaderText = "ФИО";
                dataGridViewTeachers.Columns["Department"].HeaderText = "Отделение";

                dataGridViewTeachers.ReadOnly = false;
            }
        }

        private void LoadTopics()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                dataGridViewTopics.ReadOnly = false;
                string getTopicsQuery = "SELECT TopicID, TopicTitle FROM Topics";
                topicsAdapter = new SqlDataAdapter(getTopicsQuery, connection);
                topicsDataTable = new DataTable();
                topicsAdapter.Fill(topicsDataTable);
                topicsBindingSource.DataSource = topicsDataTable;
                dataGridViewTopics.DataSource = topicsBindingSource;
            }
        }

        private void SaveChanges()
        {
            SqlCommandBuilder studentsCommandBuilder = new SqlCommandBuilder(studentsAdapter);
            SqlCommandBuilder teachersCommandBuilder = new SqlCommandBuilder(teachersAdapter);
            SqlCommandBuilder topicsCommandBuilder = new SqlCommandBuilder(topicsAdapter);

            studentsAdapter.Update(studentsDataTable);
            teachersAdapter.Update(teachersDataTable);
            topicsAdapter.Update(topicsDataTable);

            MessageBox.Show("Изменения сохранены.");
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void ApplyStudentFilter(string filter)
        {
            studentsBindingSource.Filter = filter;
        }

        private void ApplyTeacherFilter(string filter)
        {
            teachersBindingSource.Filter = filter;
        }

        private void ApplyTopicFilter(string filter)
        {
            topicsBindingSource.Filter = filter;
        }

        private void ResetFilters()
        {
            studentsBindingSource.RemoveFilter();
            teachersBindingSource.RemoveFilter();
            topicsBindingSource.RemoveFilter();
        }

        private void buttonApplyFilter_Click(object sender, EventArgs e)
        {
            string studentFilter = textBoxStudentFilter.Text;
            string teacherFilter = textBoxTeacherFilter.Text;
            string topicFilter = textBoxTopicFilter.Text;

            ApplyStudentFilter(studentFilter);
            ApplyTeacherFilter(teacherFilter);
            ApplyTopicFilter(topicFilter);
        }
    }
}
