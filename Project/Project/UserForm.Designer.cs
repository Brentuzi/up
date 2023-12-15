
namespace Project
{
    partial class UserForm
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
            this.textBoxFullName = new System.Windows.Forms.Label();
            this.textBoxFaculty = new System.Windows.Forms.Label();
            this.textBoxGroupName = new System.Windows.Forms.Label();
            this.labelTopic = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelExamGrade = new System.Windows.Forms.Label();
            this.labelDefenseGrade = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.AutoSize = true;
            this.textBoxFullName.Location = new System.Drawing.Point(79, 47);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(51, 20);
            this.textBoxFullName.TabIndex = 0;
            this.textBoxFullName.Text = "label1";
            // 
            // textBoxFaculty
            // 
            this.textBoxFaculty.AutoSize = true;
            this.textBoxFaculty.Location = new System.Drawing.Point(106, 97);
            this.textBoxFaculty.Name = "textBoxFaculty";
            this.textBoxFaculty.Size = new System.Drawing.Size(51, 20);
            this.textBoxFaculty.TabIndex = 0;
            this.textBoxFaculty.Text = "label1";
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.AutoSize = true;
            this.textBoxGroupName.Location = new System.Drawing.Point(79, 151);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(51, 20);
            this.textBoxGroupName.TabIndex = 0;
            this.textBoxGroupName.Text = "label1";
            // 
            // labelTopic
            // 
            this.labelTopic.AutoSize = true;
            this.labelTopic.Location = new System.Drawing.Point(22, 197);
            this.labelTopic.Name = "labelTopic";
            this.labelTopic.Size = new System.Drawing.Size(51, 20);
            this.labelTopic.TabIndex = 0;
            this.labelTopic.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxFullName);
            this.groupBox1.Controls.Add(this.labelTopic);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxFaculty);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxGroupName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 265);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Факультет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Группа";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelExamGrade);
            this.groupBox2.Controls.Add(this.labelDefenseGrade);
            this.groupBox2.Location = new System.Drawing.Point(12, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Оценки";
            // 
            // labelExamGrade
            // 
            this.labelExamGrade.AutoSize = true;
            this.labelExamGrade.Location = new System.Drawing.Point(22, 31);
            this.labelExamGrade.Name = "labelExamGrade";
            this.labelExamGrade.Size = new System.Drawing.Size(51, 20);
            this.labelExamGrade.TabIndex = 0;
            this.labelExamGrade.Text = "label1";
            // 
            // labelDefenseGrade
            // 
            this.labelDefenseGrade.AutoSize = true;
            this.labelDefenseGrade.Location = new System.Drawing.Point(22, 63);
            this.labelDefenseGrade.Name = "labelDefenseGrade";
            this.labelDefenseGrade.Size = new System.Drawing.Size(51, 20);
            this.labelDefenseGrade.TabIndex = 0;
            this.labelDefenseGrade.Text = "label1";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label textBoxFullName;
        private System.Windows.Forms.Label textBoxFaculty;
        private System.Windows.Forms.Label textBoxGroupName;
        private System.Windows.Forms.Label labelTopic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelExamGrade;
        private System.Windows.Forms.Label labelDefenseGrade;
    }
}