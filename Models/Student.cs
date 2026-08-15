using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class Student
    {
        [BsonId]
        public int StudentID { get; set; }

        [Required(ErrorMessage = "Student Name is required")]
        public string? StudentName { get; set; }

        [Required(ErrorMessage = "Roll / Enrollment No is required")]
        public string? RollNo { get; set; }

        [Required(ErrorMessage = "Email Address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? EmailAddress { get; set; }

        [Required(ErrorMessage = "Mobile No is required")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Mobile No must be exactly 10 digits")]
        public string? MobileNo { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        [Required(ErrorMessage = "Department is required")]
        public string? DepartmentName { get; set; }

        [Required(ErrorMessage = "Course is required")]
        public string? CourseName { get; set; }

        [Required(ErrorMessage = "Classroom is required")]
        public string? ClassroomName { get; set; }

        public bool IsActive { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }

        public DateTime? DropDate { get; set; }

        public string? DropReason { get; set; }
    }
}
