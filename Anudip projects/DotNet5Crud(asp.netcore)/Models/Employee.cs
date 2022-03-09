﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DotNet5Crud.Models
{
    public class EmployeeValidator
    {
        [Required]
        [MaxLength(50)]
        [Display(Name = "Employee Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Employee Salary")]
        public decimal Salary { get; set; }

        [Required]
        [Display(Name = "Joining Date")]
        public decimal JoiningDate { get; set; }
    }

    [ModelMetadataType(typeof(EmployeeValidator))]
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Designation { get; set; }
        public decimal Salary { get; set; }
        public DateTime JoiningDate { get; set; }
    }
}
