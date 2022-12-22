

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EfCoreTrackingDataChangesDemo;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}
