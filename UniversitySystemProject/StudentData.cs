using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversitySystemProject
{
    public partial class StudentData : Form
    {
        public string FacultyNumber { get; set; }
        public string IDNumber { get; set; }
        public string StudentName { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public double AverageScore { get; set; }


        public StudentData()
        {
            InitializeComponent();
        }

        private void StudentData_Load(object sender, EventArgs e)
        {
            cbGender.Items.Add("Жена");
            cbGender.Items.Add("Мъж");
            this.cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FacultyNumber = tbFacultyNumber.Text;
            IDNumber = tbIDNumber.Text;
            StudentName = tbStudentName.Text;
            Gender = cbGender.SelectedItem.ToString();
            PhoneNumber = tbPhoneNumber.Text;
            AverageScore = double.Parse(tbAverageScore.Text);

            this.DialogResult = DialogResult.OK;
        }
  
        private bool ValidateNumberSequence(TextBox tb, ErrorProvider ep)
        {
            if (IsNumberSequenceValid(tb.Text))
            {
                ep.Icon = Properties.Resources.iconfinder_sign_error;
                ep.SetError(tb, "");
                return true;
            }
            else
            {
                ep.SetError(tb, "Невалидно въведена информация!");
                return false;
            }
        }
        private bool IsNumberSequenceValid(string aText)
        {
            if (aText.Length!=10)
            {
                return false;
            }
            for (int i = 0; i < aText.Length; i++)
            {
                if (!Char.IsDigit(aText[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private void tbFacultyNumber_Validating(object sender, CancelEventArgs e)
        {
            ValidateNumberSequence(tbFacultyNumber, epFacultyNumber);
            ValidateSaveButton();
        }

        private void tbIDNumber_Validating(object sender, CancelEventArgs e)
        {
            ValidateNumberSequence(tbIDNumber,epIDNumber);
            ValidateSaveButton();
        }
  
        private void tbPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            ValidateNumberSequence(tbPhoneNumber, epPhoneNumber);
            ValidateSaveButton();
        }

        private void tbStudentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)||e.KeyChar==8||e.KeyChar==32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cbGender_Validating(object sender, CancelEventArgs e)
        {
            if (cbGender.Text=="")
            {
                epGenderChoice.Icon = Properties.Resources.iconfinder_sign_error;
                epGenderChoice.SetError(cbGender, "Няма избрана опция!");
            }
            else
            {
                epGenderChoice.SetError(cbGender, "");
            }
            ValidateSaveButton();
        }

        private void tbAverageScore_Validating(object sender, CancelEventArgs e)
        {
            if (tbAverageScore.Text == "")
            {
                epAverageScore.Icon = Properties.Resources.iconfinder_sign_error;
                epAverageScore.SetError(tbAverageScore, "Правилно въведен среден успех е по следния пример: 6,00!");
            }
            else
            {
                epAverageScore.SetError(tbAverageScore, "");
            }
            ValidateSaveButton();
        }

        private void ValidateSaveButton()
        {
            
            if (tbFacultyNumber.Text!="" && tbIDNumber.Text!="" && tbStudentName.Text!="" && cbGender.SelectedItem.ToString() != "" 
                && tbPhoneNumber.Text!= "" && tbAverageScore.Text!= "")
            {              
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }
    }
}
