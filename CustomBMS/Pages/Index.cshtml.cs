using CustomBMS.Models;
using CustomBMS.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Principal;

namespace CustomBMS.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ILogger<IndexModel> _logger;
        private readonly UserServices userService;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            userService = new UserServices();
        }

        public void OnGet()
        {
            
        }

        //public string ModelName { get; set; }

        
        public AuthenticateVM authenticate = new AuthenticateVM();

        
        public IActionResult OnPost()
        {
            authenticate.UserName = Request.Form["authenticate.UserName"];
            authenticate.Password = Request.Form["authenticate.Password"]; 

            User? curentUser = userService.Authenticate(authenticate);
            if (curentUser != null) 
            {
                return RedirectToPage("Account", new { Id = curentUser.ID});
            }
            return Page(); 
        }

    }


}