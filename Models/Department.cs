using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class Department
    {
        [BsonId]
        public int DepartmentID { get; set; }

        [Required(ErrorMessage = "Department Name is required")]
        [MinLength(2, ErrorMessage = "Department Name must be at least 2 characters")]
        public string? DepartmentName { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }
    }
}
