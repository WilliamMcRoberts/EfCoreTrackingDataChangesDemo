


using EfCoreTrackingDataChangesDemo;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello World!");

var student = new Student { Id = 1,  Name = "William Alex Jones" };

var broker = new StorageBroker();

//broker.Add(student);

//broker.Update(student);


IQueryable<Student> students =
    broker.Students.TemporalAll();

Console.WriteLine();

//broker.SaveChanges();
