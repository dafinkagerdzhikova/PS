using StudentInfoSystem.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
namespace StudentInfoSystem
{
     public class TestFunc : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return TestStudentsIfEmpty();
        }

        public void Execute(object? parameter)
        {
            CopyTestStudents();
        }

        private void CopyTestStudents()
        {
            StudentInfoContext context = new StudentInfoContext();

            foreach (Student student in StudentData.TestStudents)
            {
                context.Students.Add(student);
            }

            context.SaveChanges();
        }

        public bool TestStudentsIfEmpty()
        {
            StudentInfoContext context = new StudentInfoContext();
            IEnumerable<Student> students = context.Students;
            int studentsCount = students.Count();
            return studentsCount == 0;
        }
    }
}