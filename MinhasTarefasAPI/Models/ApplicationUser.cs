using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasTarefasAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int FullName { get; set; }
        [ForeignKey("UserId")]
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
