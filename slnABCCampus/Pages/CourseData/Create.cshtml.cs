using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using slnABCCampus.Data;
using slnABCCampus.Model;

namespace slnABCCampus.Pages.CourseData
{
    public class CreateModel : PageModel
    {
        public void OnGet()
        {
        }

        private readonly AppDBContext _db;
        public tblCourses tblCourses { get; set; }

        public CreateModel(AppDBContext db)
        {
            _db = db;
        }


        public async Task<IActionResult> OnPost(tblCourses tblCourses)
        {
            if (ModelState.IsValid)
            {
                //if(tblStudents.szCity is null)
                //{
                //    ModelState.AddModelError(string.Empty,"City Cannot be null");
                //}

                await _db.TblCourses.AddAsync(tblCourses);
                await _db.SaveChangesAsync();
                return RedirectToPage("Create");
                

            }
            return Page();
        }
    }
}
