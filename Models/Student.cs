using System.ComponentModel.DataAnnotations;

namespace StudentsManagementSystem.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string FullName =>$"{FirstName} {MiddleName} {LastName}";

        public string EmailAddress { get; set; }
         
        public int PhoneNumber { get; set; }

        public string Gender { get; set; }
    }
}
 