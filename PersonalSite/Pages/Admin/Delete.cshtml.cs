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
    public class DeleteModel : PageModel
    {
        private readonly PersonalSite.DBContext _context;

        public DeleteModel(PersonalSite.DBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MessageViewModel MessageViewModel { get; set; }

        public bool LogedIn { get; set; }
        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (HttpContext.Request.Cookies.ContainsKey("Token"))
            {
                var log = HttpContext.Request.Cookies["Token"];
                if (log == Startup.loginToken)
                {
                    LogedIn = true;
                    MessageViewModel = await _context.Messages.FirstOrDefaultAsync(m => m.Id == id);

                    if (MessageViewModel == null)
                    {
                        return NotFound();
                    }
                    return Page();
                }
                else
                {
                    LogedIn = false;
                    return RedirectToPage("Index");
                }
            }
            else
            {
                LogedIn = false;
                return RedirectToPage("Index");
            }
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MessageViewModel = await _context.Messages.FindAsync(id);

            if (MessageViewModel != null)
            {
                _context.Messages.Remove(MessageViewModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
