using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PersonalSite;

namespace PersonalSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly PersonalSite.DBContext _context;

        public IndexModel(PersonalSite.DBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string User { get; set; }

        [BindProperty]
        public string Pass { get; set; }

        public bool LogedIn { get; set; }
        public IList<MessageViewModel> MessageViewModel { get; set; }

        public async Task OnGetAsync()
        {
            if (HttpContext.Request.Cookies.ContainsKey("Token"))
            {
                var log = HttpContext.Request.Cookies["Token"];
                if (log == Startup.loginToken)
                {
                    LogedIn = true;
                    MessageViewModel = await _context.Messages.ToListAsync();
                }
                else
                {
                    LogedIn = false;
                }
            }
            else
            {
                LogedIn = false;
            }
        }
        public async Task OnPost()
        {
            if (User == Startup.UserName && Pass == Startup.Password)
            {
                LogedIn = true;
                MessageViewModel = await _context.Messages.ToListAsync();
                HttpContext.Response.Cookies.Append("Token", Startup.loginToken, new Microsoft.AspNetCore.Http.CookieOptions
                {
                    Expires = DateTimeOffset.Now.AddMinutes(30)
                });
            }
        }
    }
}
