using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace ECommerce.Models
{
    public class Produit
    {
        [Key]
        public int IdProduit { get; set; }
        public string Titre { get; set; }
        public float Prix { get; set; }
        public string Description { get; set; }
    }
}