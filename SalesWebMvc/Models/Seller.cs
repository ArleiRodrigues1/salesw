using System;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Insira o nome")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Máximo de 60 e mínimo de 3 caracteres.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Insira o email")]
        [EmailAddress(ErrorMessage = "Entre com um email válido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Insira a data de nascimento")]
        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Aniversario { get; set; }

        [Required(ErrorMessage = "Insira o salário")]
        [Range(100.0, 50000.0, ErrorMessage = "Mínimo de R$100 e máximp de R$5000,00")]
        [Display(Name = "Salário")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double SalarioBase { get; set; }
        public Department Department { get; set; }
        [Required(ErrorMessage = "Selecione o Departamento")]
        [Display(Name = "Departamento")]
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();


        public Seller() { }

        public Seller(int id, string nome, string email, DateTime aniversario, double salarioBase, Department department)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Aniversario = aniversario;
            SalarioBase = salarioBase;
            Department = department;
        }

        public Seller(string nome, string email, DateTime aniversario, double salarioBase, Department department)
        {
            Nome = nome;
            Email = email;
            Aniversario = aniversario;
            SalarioBase = salarioBase;
            Department = department;
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
            return Sales.Where(sr => sr.Data >= initial && sr.Data <= final).Sum(sr => sr.Amount);
        }
    }
}