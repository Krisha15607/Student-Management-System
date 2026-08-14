using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class Staff
    {
        [BsonId]
        public int StaffID { get; set; }

        [Required(ErrorMessage = "Department is required")]
        public string? DepartmentName { get; set; }

        [Required(ErrorMessage = "Staff Name is required")]
        [MinLength(3, ErrorMessage = "Staff Name must be at least 3 characters")]
        public string? StaffName { get; set; }

        [Required(ErrorMessage = "Mobile No is required")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Mobile No must be exactly 10 digits")]
        public string? MobileNo { get; set; }

        [Required(ErrorMessage = "Email Address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? EmailAddress { get; set; }

        public string? Remarks { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }
    }
}
