using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class Course
    {
        [BsonId]
        public int CourseID { get; set; }

        [Required(ErrorMessage = "Course Name is required")]
        [MinLength(2, ErrorMessage = "Course Name must be at least 2 characters")]
        public string? CourseName { get; set; }

        public string? Remarks { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }
    }
}
