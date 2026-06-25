using FifthTask.Data;
using FifthTask.Models;

using StudentDBContext context = new();

Console.Write("Enter First Name: ");
string firstName = Console.ReadLine();

Console.Write("Enter Last Name: ");
string lastName = Console.ReadLine();

Console.Write("Enter Age: ");
int age = int.Parse(Console.ReadLine());

Console.Write("Enter Address: ");
string address = Console.ReadLine();

Console.Write("Enter Email: ");
string email = Console.ReadLine();

Console.Write("Enter Phone Number: ");
string phoneNumber = Console.ReadLine();

Student student = new Student()
{
    Name = firstName,
    LastName = lastName,
    Age = age,
    Address = address,
    Email = email,
    PhoneNumber = phoneNumber
};

context.Add(student);
context.SaveChanges();

Console.WriteLine("Student is saved");