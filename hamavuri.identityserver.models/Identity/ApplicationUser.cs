using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hmavuri.identityserver.models
{
    public class ApplicationUser : IdentityUser
    {
        public new Guid Id { get; set; }
        public string FistName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FamilyName { get; set; }
        public string Locale { get; set; }
        public string TimeZone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string Website { get; set; }
        public string NickName { get; set; }
        public string ProfilePictureUrl { get; set; }
    }
}
