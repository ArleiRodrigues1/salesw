﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Insira o nome")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Máximo de 60 e mínimo de 3 caracteres.")]
        public string Nome { get; set; }

        public List<Department> Departments = new List<Department>();
        public List<Seller> Sellers = new List<Seller>();
        public Department() { }

        public Department(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}