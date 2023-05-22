using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Primitives;

namespace BD_Lab_OLX.Models
{
    public class Users
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

    }
}
    