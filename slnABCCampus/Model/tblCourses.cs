using System.ComponentModel.DataAnnotations;

namespace slnABCCampus.Model
{
    public class tblCourses
    {
        [Key]
        public decimal dCourseID { get; set; }
        [Required]
        public string? szCourseName { get; set; }
        public string? szLecName { get; set; }


    }
}
