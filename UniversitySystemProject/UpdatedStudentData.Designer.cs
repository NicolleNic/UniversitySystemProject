
namespace UniversitySystemProject
{
    partial class UpdatedStudentData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatedStudentData));
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.cbNewGender = new System.Windows.Forms.ComboBox();
            this.tbNewAverageScore = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNewPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNewStudentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNewIDNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNewFacultyNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.epNewFacultyNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNewIDNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNewName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNewGenderChoice = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNewPhoneNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNewAverageScore = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNewFacultyNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNewIDNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNewName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNewGenderChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNewPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNewAverageScore)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.ForeColor = System.Drawing.Color.Black;
            this.btnSaveChanges.Location = new System.Drawing.Point(357, 410);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(259, 42);
            this.btnSaveChanges.TabIndex = 13;
            this.btnSaveChanges.Text = "Запази промените";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // cbNewGender
            // 
            this.cbNewGender.FormattingEnabled = true;
            this.cbNewGender.Location = new System.Drawing.Point(267, 240);
            this.cbNewGender.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.cbNewGender.Name = "cbNewGender";
            this.cbNewGender.Size = new System.Drawing.Size(349, 36);
            this.cbNewGender.TabIndex = 12;
            this.cbNewGender.Validating += new System.ComponentModel.CancelEventHandler(this.cbNewGender_Validating);
            // 
            // tbNewAverageScore
            // 
            this.tbNewAverageScore.Location = new System.Drawing.Point(267, 346);
            this.tbNewAverageScore.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.tbNewAverageScore.MaxLength = 5;
            this.tbNewAverageScore.Name = "tbNewAverageScore";
            this.tbNewAverageScore.Size = new System.Drawing.Size(349, 34);
            this.tbNewAverageScore.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 352);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Среден успех";
            // 
            // tbNewPhoneNumber
            // 
            this.tbNewPhoneNumber.Location = new System.Drawing.Point(267, 294);
            this.tbNewPhoneNumber.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.tbNewPhoneNumber.MaxLength = 15;
            this.tbNewPhoneNumber.Name = "tbNewPhoneNumber";
            this.tbNewPhoneNumber.Size = new System.Drawing.Size(349, 34);
            this.tbNewPhoneNumber.TabIndex = 9;
            this.tbNewPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.tbNewPhoneNumber_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 300);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 248);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Пол";
            // 
            // tbNewStudentName
            // 
            this.tbNewStudentName.Location = new System.Drawing.Point(267, 188);
            this.tbNewStudentName.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.tbNewStudentName.Name = "tbNewStudentName";
            this.tbNewStudentName.Size = new System.Drawing.Size(349, 34);
            this.tbNewStudentName.TabIndex = 5;
            this.tbNewStudentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNewStudentName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Име и фамилия";
            // 
            // tbNewIDNumber
            // 
            this.tbNewIDNumber.Location = new System.Drawing.Point(267, 136);
            this.tbNewIDNumber.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.tbNewIDNumber.MaxLength = 10;
            this.tbNewIDNumber.Name = "tbNewIDNumber";
            this.tbNewIDNumber.Size = new System.Drawing.Size(349, 34);
            this.tbNewIDNumber.TabIndex = 3;
            this.tbNewIDNumber.Validating += new System.ComponentModel.CancelEventHandler(this.tbNewIDNumber_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "ЕГН";
            // 
            // tbNewFacultyNumber
            // 
            this.tbNewFacultyNumber.Location = new System.Drawing.Point(267, 84);
            this.tbNewFacultyNumber.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.tbNewFacultyNumber.MaxLength = 10;
            this.tbNewFacultyNumber.Name = "tbNewFacultyNumber";
            this.tbNewFacultyNumber.Size = new System.Drawing.Size(349, 34);
            this.tbNewFacultyNumber.TabIndex = 1;
            this.tbNewFacultyNumber.Validating += new System.ComponentModel.CancelEventHandler(this.tbNewFacultyNumber_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Факултетен номер";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnSaveChanges);
            this.panel1.Controls.Add(this.cbNewGender);
            this.panel1.Controls.Add(this.tbNewAverageScore);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbNewPhoneNumber);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbNewStudentName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbNewIDNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbNewFacultyNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 476);
            this.panel1.TabIndex = 16;
            // 
            // epNewFacultyNumber
            // 
            this.epNewFacultyNumber.ContainerControl = this;
            // 
            // epNewIDNumber
            // 
            this.epNewIDNumber.ContainerControl = this;
            // 
            // epNewName
            // 
            this.epNewName.ContainerControl = this;
            // 
            // epNewGenderChoice
            // 
            this.epNewGenderChoice.ContainerControl = this;
            // 
            // epNewPhoneNumber
            // 
            this.epNewPhoneNumber.ContainerControl = this;
            // 
            // epNewAverageScore
            // 
            this.epNewAverageScore.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(35, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(493, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Моля, въвеждайте информацията на кирилица!";
            // 
            // UpdatedStudentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(655, 561);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "UpdatedStudentData";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Промяна на информацията на студент";
            this.Load += new System.EventHandler(this.UpdatedStudentData_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNewFacultyNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNewIDNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNewName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNewGenderChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNewPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNewAverageScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.ComboBox cbNewGender;
        private System.Windows.Forms.TextBox tbNewAverageScore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNewPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNewStudentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNewIDNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNewFacultyNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider epNewFacultyNumber;
        private System.Windows.Forms.ErrorProvider epNewIDNumber;
        private System.Windows.Forms.ErrorProvider epNewName;
        private System.Windows.Forms.ErrorProvider epNewGenderChoice;
        private System.Windows.Forms.ErrorProvider epNewPhoneNumber;
        private System.Windows.Forms.ErrorProvider epNewAverageScore;
        private System.Windows.Forms.Label label7;
    }
}