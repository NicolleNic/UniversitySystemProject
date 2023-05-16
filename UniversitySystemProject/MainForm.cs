using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversitySystemProject
{
    public partial class MainForm : Form
    {
        readonly string filePath = "students.csv";
        readonly char separator = '/';
        List<string> facultyNumbers = new List<string>() ;
        List<string> idNumbers= new List<string>() ;
        List<string> studentNames= new List<string>() ;
        List<string> genderStudents = new List<string>() ;
        List<string> phoneNumbers = new List<string>() ;
        List<double> averageScores= new List<double>() ;

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Timer();
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] studentInfo = line.Split(separator);

                        facultyNumbers.Add(studentInfo[0]);
                        idNumbers.Add(studentInfo[1]);
                        studentNames.Add(studentInfo[2]);
                        genderStudents.Add(studentInfo[3]);
                        phoneNumbers.Add(studentInfo[4]);
                        averageScores.Add(double.Parse(studentInfo[5]));
                    }
                }
            }
            UpdateListItems();
            lbStudents.SelectedItems.Clear();


        }
        private void UpdateListItems()
        {
            lbStudents.Items.Clear();
            for (int i = 0; i < facultyNumbers.Count; i++)
            {
                string item = string.Format(@"Фак.№: {0}, ЕГН: {1}, Име:{2}, Пол: {3},  Телефон: {4}, Среден успех: {5}", 
                    facultyNumbers[i], idNumbers[i], studentNames[i], genderStudents[i], phoneNumbers[i], averageScores[i]);
                lbStudents.Items.Add(item);
                int numberOfStudents = lbStudents.Items.Count;
                lblStudentsCount.Text = "Брой студенти в системата: " + numberOfStudents;
            }
        }
        private void AddNewStudentToolStripMenuItem_Click(object sender, EventArgs e) //Open an additional form to add the info of a new student 
        {
            StudentData form = new StudentData();
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK)
            {
                if (facultyNumbers.Contains(form.FacultyNumber))
                {
                    MessageBox.Show("Студент с такъв факултетен номер вече съществува.");
                    return;
                }
                if (idNumbers.Contains(form.IDNumber))
                {
                    MessageBox.Show("Студент с такъв идентификационен номер вече съществува.");
                    return;
                }
                if (phoneNumbers.Contains(form.PhoneNumber))
                {
                    MessageBox.Show("Студент с такъв телефонен номер вече съществува.");
                    return;
                }

                facultyNumbers.Add(form.FacultyNumber);
                idNumbers.Add(form.IDNumber);
                studentNames.Add(form.StudentName);
                genderStudents.Add(form.Gender);
                phoneNumbers.Add(form.PhoneNumber);
                averageScores.Add(form.AverageScore);
                UpdateListItems();

                using (FileStream fs = new FileStream(filePath, FileMode.Append))
                {
                    using (StreamWriter writer = new StreamWriter(fs))
                    {
                        writer.WriteLine(form.FacultyNumber + separator + form.IDNumber + separator + form.StudentName + separator + form.Gender + separator + form.PhoneNumber + separator + form.AverageScore);
                        writer.Close();
                    }
                }
            }
            else if (res==DialogResult.Cancel)
            {
                MessageBox.Show("Няма добавена нова информация.");
            }
        }
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e) //Delete information from the ListBox
        {
            try
            {
                int index = lbStudents.SelectedIndex;

                facultyNumbers.RemoveAt(index);
                idNumbers.RemoveAt(index);
                studentNames.RemoveAt(index);
                genderStudents.RemoveAt(index);
                phoneNumbers.RemoveAt(index);
                averageScores.RemoveAt(index);

                UpdateListItems();
                RefreshFile();
            }
            catch (ArgumentOutOfRangeException argumentOutOfRange)
            {
                MessageBox.Show("Няма избрана информация за изтриване!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e) //Edit the existing row of information by rewriting it from scratch
        {
            if (lbStudents.SelectedIndex==-1)
            {
                MessageBox.Show("Няма избрана информация за редактиране!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                int indexEdit = lbStudents.SelectedIndex;
                UpdatedStudentData ufrm = new UpdatedStudentData();
                DialogResult res = ufrm.ShowDialog();

                if (res==DialogResult.OK)
                {
                    facultyNumbers[indexEdit] = (ufrm.NewFacultyNumber);
                    idNumbers[indexEdit] = (ufrm.NewIDNumber);
                    studentNames[indexEdit] = (ufrm.NewStudentName);
                    genderStudents[indexEdit] = (ufrm.NewGender);
                    phoneNumbers[indexEdit] = (ufrm.NewPhoneNumber);
                    averageScores[indexEdit] = (ufrm.NewAverageScore);

                    UpdateListItems();
                    RefreshFile();
                }
                else if (res==DialogResult.Cancel)
                {
                    return;
                }
            }         
        }

        private void RefreshFile()
        {
              using (StreamWriter writer = new StreamWriter(filePath))
                 {
                    for (int i = 0; i < facultyNumbers.Count; i++)
                    {
                        writer.WriteLine(facultyNumbers[i] + separator + idNumbers[i]+ separator + studentNames[i] + separator + genderStudents[i] + separator + phoneNumbers[i] + separator + averageScores[i]);
                    }
                 }
        }
        private void linkPU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Link to the university site.
        {
            System.Diagnostics.Process.Start("https://uni-plovdiv.bg/");
            linkPU.LinkVisited = true;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) //Confirmiing exit of the form.
        {
            DialogResult res = MessageBox.Show("Сигурни ли сте, че искате да напуснете системата?", "Потвърждаване на напускането", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void lbStudents_MouseDoubleClick(object sender, MouseEventArgs e) //With a double click the information of the chosen row is displayed in a message box.
        {
            int currentIndex = lbStudents.SelectedIndex;
            string currentFacultyNumber = facultyNumbers[currentIndex];
            string currentName = studentNames[currentIndex];
            string currentID = idNumbers[currentIndex];
            string currentGender = genderStudents[currentIndex];
            string currentPhoneNumber = phoneNumbers[currentIndex];
            double currentAverageScore = averageScores[currentIndex];
            MessageBox.Show("Фак.№:" + currentFacultyNumber + Environment.NewLine +
                "ЕГН: " + currentID + Environment.NewLine +
                "Име:" + currentName + Environment.NewLine +
                "Пол: " + currentGender + Environment.NewLine +
                "Телефон: " + currentPhoneNumber + Environment.NewLine +
                "Среден успех: " + currentAverageScore, "Информация за студента", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbFindStudent.Text!="")
            {
                lbStudents.SelectedItems.Clear();
                for (int i = lbStudents.Items.Count - 1; i >= 0; i--)
                {
                    if (lbStudents.Items[i].ToString().ToLower().Contains(tbFindStudent.Text.ToLower()))
                    {
                        lbStudents.SetSelected(i, true);
                    }
                }
            }
            else
            {
                MessageBox.Show("Няма въведена информация за търсене!","Внимание",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
          
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "Text File|*.txt";
            saveFileDialog.Title = "Запиши файл";
            saveFileDialog.FileName = "Students";


            if (saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    using (StreamWriter streamwriter = new StreamWriter(fs))
                    {
                        for (int i = 0; i < lbStudents.Items.Count; i++)
                        {
                            streamwriter.WriteLine(lbStudents.Items[i]);
                        }
                    }
                }
            }
        }

        private void tbFindStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnSearch.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        private void Timer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Enabled = true;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            lblDateAndTime.Text = DateTime.Now.ToString();
        }
    }
}
