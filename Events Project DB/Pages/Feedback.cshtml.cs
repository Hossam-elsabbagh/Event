using Events_Project_DB.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace Events_Project_DB.Pages
{
    public class FeedbackModel : PageModel
    {
        private dbclass t1;
        public DataTable Table { get; set; }
        public DataTable Table1 { get; set; }
        public DataTable Table2 { get; set; }
        [BindProperty]
        public string Username1 { get; set; }
        [BindProperty]
        public int rate { get; set; }
        [BindProperty]
        public string comment { get; set; }
        [BindProperty]
        public int eventid { get; set; }

        public string output { get; set; }
        public FeedbackModel(ILogger<FeedbackModel> logger, dbclass t1)
        {

            this.t1 = t1;
        }
        public void OnGet()
        {
            Username1 = t1.Username;
            Table = t1.ShowFeedback();
            Table1 = t1.GetEventsForUser(Username1);
        }

        public IActionResult OnPostSubmit()
        {

            Username1 = t1.Username;
            output = t1.AddFeedback(Username1, eventid, rate, comment);
            return RedirectToPage("/Userpage");
            
        }
    }
}
