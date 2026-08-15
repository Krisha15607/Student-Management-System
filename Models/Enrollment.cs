using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class Enrollment
    {
        [BsonId]
        public int EnrollmentID { get; set; }

        [Required(ErrorMessage = "Please select a Student")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a valid Student")]
        public int StudentID { get; set; }

        public string? StudentName { get; set; }

        [Required(ErrorMessage = "Please select a Staff / Faculty")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a valid Staff member")]
        public int StaffID { get; set; }

        public string? StaffName { get; set; }

        public bool IsActive { get; set; }

        public string? Remarks { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }
    }
}
