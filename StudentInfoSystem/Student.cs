using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Faculty { get; set; }
        public string Speciality { get; set; }
        public string EducationalQualificationDegree { get; set; }
        public string StudentStatus { get; set; }
        public string FacultyNumber { get; set; }
        public int Course { get; set; }
        public int Stream { get; set; }
        public int Group { get; set; }

        public Student(string name, string secondName, string lastName, string faculty, string speciality,
            string educationalQualificationDegree, string status, string facultyNum, int course, int stream, int group)
        {
            Name = name;
            SecondName = secondName;
            LastName = lastName;
            Faculty = faculty;
            Speciality = speciality;
            EducationalQualificationDegree = educationalQualificationDegree;
            StudentStatus = status;
            FacultyNumber = facultyNum;
            Course = course;
            Stream = stream;
            Group = group;
        }

        public Student()
        {
            Name = "Mimi";
            SecondName = "Yoncheva";
            LastName = "Ivanova";
            Faculty = "FCST";
            Speciality = "CSE";
            EducationalQualificationDegree = "Bachelor";
            StudentStatus = "Редовен";
            FacultyNumber = "12121919";
            Course = 3;
            Stream = 9;
            Group = 31;
        }

       /* public enum Status
        {
            certified,
            interrupted,
            completedSemester
        }*/
    }
}
