using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem.TestData

{
    static public class StudentData
    {

        static public List<Student> TestStudents { 
            get
            {
                ResetTestStudentData();
                return _testStudents;
            } 
            set { }
        }
        
        static private List<Student> _testStudents;

        static private void ResetTestStudentData()
        {
            if (_testStudents == null)
            {
                _testStudents = new List<Student>
                {
                    new Student
                    {
                        Name = "Yoana",
                        SecondName = "Marinova",
                        LastName = "Ivanova",
                        Faculty = "FCST",
                        Speciality = "CSE",
                        EducationalQualificationDegree = "Bachelor",
                        StudentStatus = "Редовен",
                        FacultyNumber = "121219009",
                        Course = 3,
                        Stream = 9,
                        Group = 31,
                    },
                    new Student
                    {
                        Name = "Dafinka",
                        SecondName = "Marinova",
                        LastName = "Gerdzikova",
                        Faculty = "FCST",
                        Speciality = "CSE",
                        EducationalQualificationDegree = "Bachelor",
                        StudentStatus = "Редовен",
                        FacultyNumber = "121219092",
                        Course = 3,
                        Stream = 9,
                        Group = 31,
                    },
                    new Student
                    {   Name = "Denislav",
                        SecondName = "Tsvetelinov",
                        LastName = "Lyutashki",
                        Faculty = "FCST",
                        Speciality = "CSE",
                        EducationalQualificationDegree = "Bachelor",
                        StudentStatus = "Редовен",
                        FacultyNumber = "121219099",
                        Course = 3,
                        Stream = 9,
                        Group = 31,
                    },
                };
            }
        }
    }
}

