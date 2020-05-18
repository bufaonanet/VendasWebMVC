using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;

namespace VendasWebMVC.Models
{
    /// <summary>
    /// Vendedor
    /// </summary>
    public class Seller
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} obritatório")]
        [Display(Name = "Nome")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} deve ter entre {2} a {1} caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} obritatório")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Entre com um email válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} obritatório")]
        [DataType(DataType.Date)]
        [Display(Name = "Aniversário")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "{0} obritatório")]
        [Display(Name = "Salário")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} deve ser entre {1} a {2}")]
        public double BaseSalary { get; set; }

        [Display(Name = "Departamento")]
        public Departament Departament { get; set; }
        [Display(Name = "Departamento")]
        public int DepartamentId { get; set; }

        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }
        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Departament departament)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
