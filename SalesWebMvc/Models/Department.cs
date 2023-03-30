using System;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Insira o nome")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Máximo de 60 e mínimo de 3 caracteres.")]
        public string Nome { get; set; }

        public Department() { }

        public Department(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }


    }
}
