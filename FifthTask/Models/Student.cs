using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace FifthTask.Models
{
    public class Student
    {

        public string Name { get; set; } = null!;

        public string LastName { get; set; } = null!;
        public int Age { get; set; }

        public int ID { get; set; } 

        public string? Address { get; set; }

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }




    }
}
