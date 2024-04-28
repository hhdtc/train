using EntityFramework.Core.Entities;
using EntityFramework.Infrastructure.Repositories;

namespace EntityFramework.Presentation.UI;

public class ManageDepartment
{
    private DepartmentRepository _departmentRepository = new DepartmentRepository();
    
    private void AddDepartment()
    {
        Department department = new Department();
        Console.WriteLine("Enter Name =>");
        department.DepartmentName = Console.ReadLine();
        Console.WriteLine("Enter Location =>");
        department.Location = Console.ReadLine();
        _departmentRepository.Insert(department);
    }

    private void DeleteDepartment()
    {
        Console.WriteLine("Enter Id =>");
        int id = Convert.ToInt32(Console.ReadLine());
        _departmentRepository.DeleteByID(id);
    }

    private void UpdateDepartment()
    {
        Department department = new Department();
        Console.WriteLine("Enter Id =>");
        department.Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Name =>");
        department.DepartmentName = Console.ReadLine();
        Console.WriteLine("Enter Location =>");
        department.Location = Console.ReadLine();
        _departmentRepository.Update(department);
    }

    private void PrintAll()
    {
        IEnumerable<Department> departments = _departmentRepository.GetAll();
        foreach (var department in departments)
        {
            Console.WriteLine(department.Id + "\t" + department.DepartmentName + "\t" + department.Location);
        }
    }

    private void PrintById()
    {
        Console.WriteLine("Enter Id =>");
        int id = Convert.ToInt32(Console.ReadLine());
        var department = _departmentRepository.GetById(id);
        Console.WriteLine(department.Id + "\t" + department.DepartmentName + "\t" + department.Location);
    }

    public void Run()
    {
        DeleteDepartment();
    }
}