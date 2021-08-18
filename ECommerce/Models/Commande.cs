using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace ECommerce.Models
{
    public class Commande
    {
        [Key]
        public int IdCommande { get; set; }
        public int IdClient { get; set; }
        public int[] Produit { get; set; }
        public int IdCommercial { get; set; }
        public string DateCom { get; set; }
        public string code { get; set; }
    }
}