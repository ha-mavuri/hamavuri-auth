using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hmavuri.identityserver.Models
{
    public class ApplicationRole : IdentityRole
    {
        public new Guid Id { get; set; }
    }
}
