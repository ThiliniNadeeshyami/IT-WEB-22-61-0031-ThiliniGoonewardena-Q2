using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using slnABCCampus.Data;
using slnABCCampus.Model;
using static System.Net.Mime.MediaTypeNames;

namespace slnABCCampus.Pages.StudentData
{
    public class IndexModel : PageModel
    {
        private readonly AppDBContext _db;
        public IEnumerable<tblStudents> StudentDetail { get; set; }
      

        public IndexModel(AppDBContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            StudentDetail = _db.TblStudents;
           
        }
    }
}
