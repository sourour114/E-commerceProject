using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Client
    {
        [Key]
        public int IdClient { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int NumeroTel { get; set; }
        public string Adresse { get; set; }

    }
}