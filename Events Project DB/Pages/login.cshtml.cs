using Events_Project_DB.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Events_Project_DB.Pages
{
    public class loginModel : PageModel
    {
        //private dbclass t1;
        [BindProperty]
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string UserError { get; set; }
        public string Guest { get; set; }

        private readonly ILogger<loginModel> _logger;
        private readonly dbclass _t1;
        public loginModel(ILogger<loginModel> logger, dbclass t1)
        {
            _logger = logger;
            _t1 = t1;
        }

        public DataTable Table { get; set; }
        public DataTable Table1 { get; set; }
        public DataTable Table2 { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Table = _t1.ShowTable("Normal_User");
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    if (Username == Table.Rows[i]["Username"].ToString() && Password == Table.Rows[i]["Password"].ToString())
                    {
                        _t1.username1(Username);
                        return RedirectToPage("/UserPage", new { Username = Username });


                    }
                }

            }
            UserError = "Username or password are incorrect";
            return Page();


        }
    }
}
