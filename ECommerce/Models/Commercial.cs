using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace ECommerce.Models
{
    public class Commercial : Users
    {
        [Key]
        public int IdCommercial { get; set; }

        public double Salaire { get; set; }

    }
}