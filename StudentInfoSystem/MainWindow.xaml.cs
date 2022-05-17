using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          
        }

        private void clearButton_OnClick(object sender, RoutedEventArgs e)
        {
            ClearText();
        }

   

        private void ClearText()
        {
            txtName.Text = string.Empty;
            txtSecName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtFaculty.Text = string.Empty;
            txtOKS.Text = string.Empty;
            txtSpeciality.Text = string.Empty;
            txtStatus.Text = string.Empty;
            txtStream.Text = string.Empty;
            txtGroup.Text = string.Empty;
            txtFacNum.Text = string.Empty;
            txtCourse.Text = string.Empty;
        }

        public void EnterStudentData(Student student) { 

            if (student != null)
            {
                txtName.Text = student.Name;
                txtSecName.Text = student.SecondName;
                txtLastName.Text = student.LastName;
                txtFaculty.Text = student.Faculty;
                txtOKS.Text = student.EducationalQualificationDegree;
                txtSpeciality.Text = student.Speciality;
            
                txtStream.Text = student.Stream.ToString();
                txtGroup.Text = student.Group.ToString();
                txtFacNum.Text = student.FacultyNumber;
                txtCourse.Text = student.Course.ToString();

                ActivateControls();
            }
            else
            {
                ClearText();
                DeactivateControls();
            }
        }

        private void ActivateControls()
        {
            gbPersonalInformation.IsEnabled = true;
            gbStudentInfo.IsEnabled = true;
        }

        private void DeactivateControls()
        {
            gbPersonalInformation.IsEnabled = false;
            gbStudentInfo.IsEnabled = false;
        }
    }
}