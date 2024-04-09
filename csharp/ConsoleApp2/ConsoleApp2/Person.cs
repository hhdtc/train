using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal abstract class Person: IPersonService
    {
        private string name;
        private Decimal salary = 0;
        public int age;
        public List<string> Address = new List<string>();



        public string[] address;
        public Decimal Salary {
            get { return salary; }
            protected set {
                if (value > 0) {
                    salary = value;
                }
            }
        }

        public string Name { 
            get { return name; }
            private set { this.name = value; }
        }
        public Person(string name) {
            this.Name = name;
        }

        public Person(string name, Decimal salary) {
            this.Name = name;
            this.Salary = salary;
        }

        public abstract String behave();
        public virtual String whoAmI() {
            return "Person";
        }

        string IPersonService.Name()
        {
            throw new NotImplementedException();
        }

        public int GetAge() {
            return age;
        }
        public virtual decimal GetSalary() { return this.Salary; }
        public List<string> GetAddress() {
            return Address;
        }

        public void AddAddress(string address)
        {
            this.Address.Add(address);
        }

        public void RemoveAddress(string address)
        {
            this.Address.Remove(address);
        }
    }

    enum Grade { 
        A,
        B,
        C,
        D,
        F,
        N,
    }

    internal class Student : Person,IStudentService {
        string StudentId = "";
        Dictionary<Course,Grade> Courses = new Dictionary<Course,Grade>();

        public Student(string name): base(name) { }
        public Student(string name, string studentId) : base(name) {
            this.StudentId = studentId;
        }

        public override String behave()
        {
            return "study";
        }

        public void DropCourse(Course course)
        {
            Courses.Remove(course);
        }

        public float GetGPA()
        {
            int counter = 0;
            float sum = 0;
            foreach (Course c in Courses.Keys) {
                if (Courses[c] == Grade.N) {
                    continue;
                }
                if (Courses[c] == Grade.A)
                {
                    sum += 4.0f;
                }
                else if (Courses[c] == Grade.B)
                {
                    sum += 3.5f;
                }
                else if (Courses[c] == Grade.C)
                {
                    sum += 3.0f;
                }
                else if (Courses[c] == Grade.D) {
                    sum += 2.0f;
                }

                counter++;
            }

            return sum / counter;
        }

        public void GradeCourse(Course course, Grade grade)
        {
            if (Courses.ContainsKey(course))
            {
                Courses[course] = grade;
            }
        }

        public void TakeCourse(Course course)
        {
            if (!Courses.ContainsKey(course))
            {
                Courses[course] = Grade.N;
            }
        }

        public override String whoAmI()
        {
            return "Student";
        }



    }

    internal class Instructor: Person,IInstructorService
    {
        string InstructorId = "";
        public DateTime Join;
        Decimal bonusSalary;
        public Decimal BonusSalary
        {
            get { return bonusSalary; }
            protected set
            {
                if (value > 0)
                {
                    bonusSalary = value;
                }
            }
        }

        public Instructor(string name) : base(name) { }
        public Instructor(string name, string instructorId) : base(name)
        {
            this.InstructorId = instructorId;
        }

        public Instructor(string name, string instructorId, int bonusSalary) : base(name)
        {
            this.InstructorId = instructorId;
            this.BonusSalary = bonusSalary;
        }

        public override String behave()
        {
            return "teach";
        }

        public override string whoAmI()
        {
            return "Instructor";
        }

        public override decimal GetSalary()
        {
            return base.GetSalary()+this.BonusSalary;
        }

        public void UpdateSalary()
        {
            this.BonusSalary = (DateTime.Today.Year - Join.Year) * 1000;
        }
    }

    internal class Course : ICourseService {
        string CourseId;
        List<Student> Students = new List<Student>();


        public Course(string courseId)
        {
            CourseId = courseId;
        }
        public void AddStudent(Student s)
        {
            if (!Students.Contains(s)) {
                Students.Add(s);
            }
        }

        public void gradeCourse(Student s, Grade grade)
        {
            s.GradeCourse(this,grade);
        }

        public void RemoveStudent(Student s)
        {
            if (Students.Contains(s))
            {
                Students.Remove(s);
            }
        }
    }

    internal class Department: IDepartmentService {
        Instructor Head;
        List<Course> Courses = new List<Course>();
        Budget Budget;

        public void AddCourse(Course course)
        {
            if (!Courses.Contains(course)) { 
                Courses.Add(course);
            }
        }

        public void Assign(Instructor head)
        {
            this.Head = head;
        }

        public List<Course> GetAllCourses()
        {
            return Courses;
        }

        public void RemoveCourse(Course course)
        {
            if(Courses.Contains(course))
            {
                Courses.Remove(course);
            }
        }

        public void SetBudget(Budget budget)
        {
            this.Budget = budget;
        }
    }

    internal class Budget {
        DateTime Start;
        DateTime End;
        DateTime Amount;
    }
}
