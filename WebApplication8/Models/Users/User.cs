using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.ViewModels.Account;
using static System.Net.WebRequestMethods;


namespace WebApplication8.Models.Users
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string? MiddleName { get; set; }

        public DateTime BirthDate { get; set; }
        public string Image { get; set; } 

        public string Status { get; set; }

        public string About { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }

        public User()
        {
            Image = "https://thispersondoesnotexist.com/";
            Status = "Ура! Я в соцсети!";
            About = "Информация обо мне.";
        }
    }
}
