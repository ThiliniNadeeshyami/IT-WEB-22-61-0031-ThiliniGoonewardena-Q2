using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using slnABCCampus.Data;
using slnABCCampus.Model;

namespace slnABCCampus.Pages.StudentData
{
    public class DeleteModel : PageModel
    {
        private readonly AppDBContext _db;
        public tblStudents tblStudents { get; set; }

        public DeleteModel(AppDBContext db)
        {
            _db = db;
        }

        public void OnGet(decimal id)
        {
            tblStudents = _db.TblStudents.Find(id);
        }

        public async Task<IActionResult> OnPost(tblStudents tblstudents)
        {
            //if(ModelState.IsValid)
            //{
                var studentIDFromDB = _db.TblStudents.Find(tblstudents.dStudentID);

              if(studentIDFromDB != null)
                {
                    _db.TblStudents.Remove(studentIDFromDB);
                    await _db.SaveChangesAsync();
                TempData["Success"] = "Student Detail Deleted Successfully";
                }

            return RedirectToPage("Index");
            //}
            //return Page();
        }
    }
}
