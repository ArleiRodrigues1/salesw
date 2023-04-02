﻿using System;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord() { }

        public SalesRecord(int id, DateTime data, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Data = data;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}