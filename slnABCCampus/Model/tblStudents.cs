using System.ComponentModel.DataAnnotations;

namespace slnABCCampus.Model
{
    public class tblStudents
    {
        [Key]
        public decimal dStudentID { get; set; }
        [Required]
        public string? szStudentName { get; set; }
        public string? szCity { get; set; }

        [Range(1,100,ErrorMessage ="Invalid Course ID")]
        public decimal dCourseID { get; set; }

    }
}
