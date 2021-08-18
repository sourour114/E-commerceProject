using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace ECommerce.Models
{
    public class Commercial
    {
        [Key]
        public int IdCommercial { get; set; }
        public string NomPrenom { get; set; }
        public string DateNaissance { get; set; }
        public double Salaire { get; set; }
        public string Mail { get; set; }
        public int Telephone { get; set; }
    }
}