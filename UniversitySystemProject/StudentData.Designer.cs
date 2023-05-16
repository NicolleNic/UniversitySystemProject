
namespace UniversitySystemProject
{
    partial class StudentData
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentData));
            this.label1 = new System.Windows.Forms.Label();
            this.tbFacultyNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIDNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbStudentName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAverageScore = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.epFacultyNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.epIDNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.epStudentName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epGenderChoice = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPhoneNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAverageScore = new System.Windows.Forms.ErrorProvider(this.components);
            this.hpAverageScore = new System.Windows.Forms.HelpProvider();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epFacultyNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIDNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epStudentName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGenderChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAverageScore)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Факултетен номер";
            // 
            // tbFacultyNumber
            // 
            this.tbFacultyNumber.Location = new System.Drawing.Point(238, 77);
            this.tbFacultyNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFacultyNumber.MaxLength = 10;
            this.tbFacultyNumber.Name = "tbFacultyNumber";
            this.tbFacultyNumber.Size = new System.Drawing.Size(349, 34);
            this.tbFacultyNumber.TabIndex = 1;
            this.tbFacultyNumber.Validating += new System.ComponentModel.CancelEventHandler(this.tbFacultyNumber_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "ЕГН";
            // 
            // tbIDNumber
            // 
            this.tbIDNumber.Location = new System.Drawing.Point(238, 131);
            this.tbIDNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIDNumber.MaxLength = 10;
            this.tbIDNumber.Name = "tbIDNumber";
            this.tbIDNumber.Size = new System.Drawing.Size(349, 34);
            this.tbIDNumber.TabIndex = 3;
            this.tbIDNumber.Validating += new System.ComponentModel.CancelEventHandler(this.tbIDNumber_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Име и фамилия";
            // 
            // tbStudentName
            // 
            this.tbStudentName.Location = new System.Drawing.Point(238, 183);
            this.tbStudentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(349, 34);
            this.tbStudentName.TabIndex = 5;
            this.tbStudentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStudentName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Пол";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 299);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Телефон";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(238, 293);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPhoneNumber.MaxLength = 10;
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(349, 34);
            this.tbPhoneNumber.TabIndex = 9;
            this.tbPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.tbPhoneNumber_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 354);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Среден успех";
            // 
            // tbAverageScore
            // 
            this.tbAverageScore.Location = new System.Drawing.Point(238, 348);
            this.tbAverageScore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAverageScore.MaxLength = 5;
            this.tbAverageScore.Name = "tbAverageScore";
            this.tbAverageScore.Size = new System.Drawing.Size(349, 34);
            this.tbAverageScore.TabIndex = 11;
            this.tbAverageScore.Validating += new System.ComponentModel.CancelEventHandler(this.tbAverageScore_Validating);
            // 
            // cbGender
            // 
            this.cbGender.Location = new System.Drawing.Point(238, 237);
            this.cbGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(349, 36);
            this.cbGender.TabIndex = 12;
            this.cbGender.Validating += new System.ComponentModel.CancelEventHandler(this.cbGender_Validating);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.Enabled = false;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(441, 408);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 42);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Запази";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.cbGender);
            this.panel1.Controls.Add(this.tbAverageScore);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbPhoneNumber);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbStudentName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbIDNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbFacultyNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 471);
            this.panel1.TabIndex = 15;
            // 
            // epFacultyNumber
            // 
            this.epFacultyNumber.ContainerControl = this;
            // 
            // epIDNumber
            // 
            this.epIDNumber.ContainerControl = this;
            // 
            // epStudentName
            // 
            this.epStudentName.ContainerControl = this;
            // 
            // epGenderChoice
            // 
            this.epGenderChoice.ContainerControl = this;
            // 
            // epPhoneNumber
            // 
            this.epPhoneNumber.ContainerControl = this;
            // 
            // epAverageScore
            // 
            this.epAverageScore.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(45, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(493, 28);
            this.label7.TabIndex = 15;
            this.label7.Text = "Моля, въвеждайте информацията на кирилица!";
            // 
            // StudentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(631, 556);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "StudentData";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация за студента";
            this.Load += new System.EventHandler(this.StudentData_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epFacultyNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIDNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epStudentName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGenderChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAverageScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFacultyNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIDNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbStudentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAverageScore;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider epFacultyNumber;
        private System.Windows.Forms.ErrorProvider epIDNumber;
        private System.Windows.Forms.ErrorProvider epStudentName;
        private System.Windows.Forms.ErrorProvider epGenderChoice;
        private System.Windows.Forms.ErrorProvider epPhoneNumber;
        private System.Windows.Forms.ErrorProvider epAverageScore;
        private System.Windows.Forms.HelpProvider hpAverageScore;
        private System.Windows.Forms.Label label7;
    }
}