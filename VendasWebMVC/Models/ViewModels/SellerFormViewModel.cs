using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace VendasWebMVC.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Departament> Departaments { get; set; }
    }
}
