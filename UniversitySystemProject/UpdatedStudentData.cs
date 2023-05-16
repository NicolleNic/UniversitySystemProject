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
    public partial class UpdatedStudentData : Form
    {
        public string NewFacultyNumber { get; set; }
        public string NewIDNumber { get; set; }
        public string NewStudentName { get; set; }
        public string NewGender { get; set; }
        public string NewPhoneNumber { get; set; }
        public double NewAverageScore { get; set; }

        public UpdatedStudentData()
        {
            InitializeComponent();
        }

        private void UpdatedStudentData_Load(object sender, EventArgs e)
        {
            cbNewGender.Items.Add("Жена");
            cbNewGender.Items.Add("Мъж");
            this.cbNewGender.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            NewFacultyNumber = tbNewFacultyNumber.Text;
            NewIDNumber = tbNewIDNumber.Text;
            NewStudentName = tbNewStudentName.Text;
            NewGender = cbNewGender.SelectedItem.ToString();
            NewPhoneNumber = tbNewPhoneNumber.Text;
            NewAverageScore = double.Parse(tbNewAverageScore.Text);

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
            if (aText.Length != 10)
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

        private void tbNewFacultyNumber_Validating(object sender, CancelEventArgs e)
          {
            ValidateNumberSequence(tbNewFacultyNumber, epNewFacultyNumber);
            ValidateSaveButton();
          }
        private void tbNewIDNumber_Validating(object sender, CancelEventArgs e)
          {
            ValidateNumberSequence(tbNewIDNumber, epNewIDNumber);
            ValidateSaveButton();
           }

        private void tbNewPhoneNumber_Validating(object sender, CancelEventArgs e)
          {
            ValidateNumberSequence(tbNewPhoneNumber, epNewPhoneNumber);
            ValidateSaveButton();
          }

        private void tbNewStudentName_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }

        private void cbNewGender_Validating(object sender, CancelEventArgs e)
            {
                if (cbNewGender.Text == "")
                {
                    epNewGenderChoice.Icon = Properties.Resources.iconfinder_sign_error;
                    epNewGenderChoice.SetError(cbNewGender, "Няма избрана опция!");
                }
                else
                {
                    epNewGenderChoice.SetError(cbNewGender, "");
                }

                ValidateSaveButton();
           }

        private void ValidateSaveButton()
        {
            if (tbNewFacultyNumber.Text != "" && tbNewIDNumber.Text != "" && tbNewStudentName.Text != "" && cbNewGender.SelectedItem.ToString() != "" 
                && tbNewPhoneNumber.Text != "" && tbNewAverageScore.Text != "")
            {
                btnSaveChanges.Enabled = true;
            }
            else
            {
                btnSaveChanges.Enabled = false;
            }
        }
    }
    } 

