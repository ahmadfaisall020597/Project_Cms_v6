﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Cms_v6.Models
{
    public class Departments
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manager_Id { get; set; }
        [InverseProperty("Departments")]
        public List<Employees> Employees { get; set; }
        [ForeignKey("Manager_Id")]
        public Employees Manager { get; set; }
    }
}
