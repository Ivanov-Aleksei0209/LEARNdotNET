using Microsoft.AspNetCore.Identity;

namespace MigrationsExamples.Models
{
    public class User : IdentityUser
    {
        public string Surname { get; set; }
        public string Post { get; set; }
    }
}
