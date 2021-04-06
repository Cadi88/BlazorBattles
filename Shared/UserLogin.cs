using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorBattles.Shared
{
    public class UserLogin
    {
        [Required(ErrorMessage ="Please enter a user name.")]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
