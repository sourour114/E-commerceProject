using ECommerce.Models.Enummeratin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class Users
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string NomPrenom { get; set; }
        public string DateNaissance { get; set; }
        public int Telephone { get; set; }
        public string LogIn { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}