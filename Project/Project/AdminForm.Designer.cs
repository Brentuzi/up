
namespace Project
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewTeachers = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewTopics = new System.Windows.Forms.DataGridView();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.textBoxStudentFilter = new System.Windows.Forms.TextBox();
            this.textBoxTeacherFilter = new System.Windows.Forms.TextBox();
            this.textBoxTopicFilter = new System.Windows.Forms.TextBox();
            this.buttonApplyFilter = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopics)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 384);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxStudentFilter);
            this.tabPage1.Controls.Add(this.dataGridViewStudents);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Студенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 62;
            this.dataGridViewStudents.RowTemplate.Height = 28;
            this.dataGridViewStudents.Size = new System.Drawing.Size(776, 262);
            this.dataGridViewStudents.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxTeacherFilter);
            this.tabPage2.Controls.Add(this.dataGridViewTeachers);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Преподователи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTeachers
            // 
            this.dataGridViewTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeachers.Location = new System.Drawing.Point(6, 15);
            this.dataGridViewTeachers.Name = "dataGridViewTeachers";
            this.dataGridViewTeachers.RowHeadersWidth = 62;
            this.dataGridViewTeachers.RowTemplate.Height = 28;
            this.dataGridViewTeachers.Size = new System.Drawing.Size(776, 261);
            this.dataGridViewTeachers.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxTopicFilter);
            this.tabPage3.Controls.Add(this.dataGridViewTopics);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(790, 351);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Темы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTopics
            // 
            this.dataGridViewTopics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTopics.Location = new System.Drawing.Point(3, 6);
            this.dataGridViewTopics.Name = "dataGridViewTopics";
            this.dataGridViewTopics.RowHeadersWidth = 62;
            this.dataGridViewTopics.RowTemplate.Height = 28;
            this.dataGridViewTopics.Size = new System.Drawing.Size(779, 270);
            this.dataGridViewTopics.TabIndex = 0;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(12, 403);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(119, 35);
            this.buttonSaveChanges.TabIndex = 1;
            this.buttonSaveChanges.Text = "Сохранить";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // textBoxStudentFilter
            // 
            this.textBoxStudentFilter.Location = new System.Drawing.Point(6, 300);
            this.textBoxStudentFilter.Name = "textBoxStudentFilter";
            this.textBoxStudentFilter.Size = new System.Drawing.Size(167, 26);
            this.textBoxStudentFilter.TabIndex = 3;
            // 
            // textBoxTeacherFilter
            // 
            this.textBoxTeacherFilter.Location = new System.Drawing.Point(6, 295);
            this.textBoxTeacherFilter.Name = "textBoxTeacherFilter";
            this.textBoxTeacherFilter.Size = new System.Drawing.Size(146, 26);
            this.textBoxTeacherFilter.TabIndex = 1;
            // 
            // textBoxTopicFilter
            // 
            this.textBoxTopicFilter.Location = new System.Drawing.Point(0, 282);
            this.textBoxTopicFilter.Name = "textBoxTopicFilter";
            this.textBoxTopicFilter.Size = new System.Drawing.Size(171, 26);
            this.textBoxTopicFilter.TabIndex = 1;
            // 
            // buttonApplyFilter
            // 
            this.buttonApplyFilter.Location = new System.Drawing.Point(164, 403);
            this.buttonApplyFilter.Name = "buttonApplyFilter";
            this.buttonApplyFilter.Size = new System.Drawing.Size(182, 35);
            this.buttonApplyFilter.TabIndex = 2;
            this.buttonApplyFilter.Text = "Пременить фильтры";
            this.buttonApplyFilter.UseVisualStyleBackColor = true;
            this.buttonApplyFilter.Click += new System.EventHandler(this.buttonApplyFilter_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonApplyFilter);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.DataGridView dataGridViewTeachers;
        private System.Windows.Forms.DataGridView dataGridViewTopics;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.TextBox textBoxStudentFilter;
        private System.Windows.Forms.TextBox textBoxTeacherFilter;
        private System.Windows.Forms.TextBox textBoxTopicFilter;
        private System.Windows.Forms.Button buttonApplyFilter;
    }
}