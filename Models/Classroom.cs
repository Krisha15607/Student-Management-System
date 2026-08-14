using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class Classroom
    {
        [BsonId]
        public int ClassroomID { get; set; }

        [Required(ErrorMessage = "Classroom Name is required")]
        [MinLength(2, ErrorMessage = "Classroom Name must be at least 2 characters")]
        public string? ClassroomName { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }
    }
}
