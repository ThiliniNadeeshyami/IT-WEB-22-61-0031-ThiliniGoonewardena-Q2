using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using slnABCCampus.Data;
using slnABCCampus.Model;

namespace slnABCCampus.Pages.StudentData
{
    public class CreateModel : PageModel
    {
        private readonly AppDBContext _db;
        public tblStudents tblStudents { get; set; }

        public IEnumerable<tblCourses> CourseDetail { get; set; }

        public CreateModel(AppDBContext db)
        {
            _db = db;
        }

        public async Task OnGet()
        {
            CourseDetail = await _db.TblCourses.ToListAsync();   
        }

        public async Task<IActionResult> OnPost(tblStudents tblstudents)
        {
            if(ModelState.IsValid)
            { 
               await  _db.TblStudents.AddAsync(tblstudents);
               await _db.SaveChangesAsync();
               TempData["Success"] = "Student Detail Added Successfully";
               return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
