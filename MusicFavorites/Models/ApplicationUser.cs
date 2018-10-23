using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace MusicFavorites.Models
{
    public class ApplicationUser : IdentityUser {

        [Required]
        public string FirstName {get;set;}

        [Required]
        public string Lastname {get;set;}
    }
}