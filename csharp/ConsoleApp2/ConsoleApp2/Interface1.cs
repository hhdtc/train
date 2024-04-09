using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal interface IPersonService
    {
        string Name();
        int GetAge();
        Decimal GetSalary();

        List<string> GetAddress();

        void AddAddress(string address);

        void RemoveAddress(string address);

    }

    internal interface IInstructorService : IPersonService {
        void UpdateSalary();

    }

    internal interface IStudentService : IPersonService
    {

        void TakeCourse(Course course);

        void DropCourse(Course course);

        void GradeCourse(Course course,Grade grade);
        
        float GetGPA();

    }

    internal interface IDepartmentService {
        void Assign(Instructor head);
        void SetBudget(Budget budget);

        void AddCourse(Course course);
        void RemoveCourse(Course course);

        List<Course> GetAllCourses();


    }

    internal interface ICourseService {

        void AddStudent(Student s);
        void RemoveStudent(Student s);

        void gradeCourse(Student s, Grade grade);


    }
}
