using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalSite
{
    public class MessageViewModel
    {
        public Guid Id { get; set; }

        [Required,EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public string Name { get; set; }
        public string Subject { get; set; }
    }
}
