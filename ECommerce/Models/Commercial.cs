using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace ECommerce.Models
{
    public class Commercial : Users
    {
        public double Salaire { get; set; }

    }
}