using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Core.Entities;

public class Department
{
    public int Id { get; set; }
    [MaxLength(50)]
    public string? DepartmentName { get; set; }
    [MaxLength(50)]
    public string? Location { get; set; }
    //navigation property
    public List<Employee> Employees { get; set; }
}