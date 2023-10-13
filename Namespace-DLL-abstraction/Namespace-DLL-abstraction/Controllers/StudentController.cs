using Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace_DLL_abstraction.Controllers
{
    public class StudentController
    {
        private readonly StudentService _studentService;

        public StudentController()
        {
            _studentService = new StudentService();
        }
        public void GetAllStudents()
        {
             var students = _studentService.GetAllStudents();

            foreach (var item in students)
            {
                string result = $"{item.FullName} - {item.Age} - {item.Email}";
                Console.WriteLine(result);
            }
        }

        public void GetStudentById()
        {
            var student = _studentService.GetById(2);
            string result = $"{student.FullName} - {student.Email}";
            Console.WriteLine(result);  
        }


        public void SumOfStudentAge()
        {
            var student = _studentService.GetAllStudents();

            var result = student.Sum(m => m.Age);

            Console.WriteLine(result);
        }

        
        public void AverageOfStudentAge()
        {
            var student = _studentService.GetAllStudents();

            var SumAge = student.Sum(m => m.Age);

            Console.WriteLine(SumAge/student.Length);
        }
    }
}
