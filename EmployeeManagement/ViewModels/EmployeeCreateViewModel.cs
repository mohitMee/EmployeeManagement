using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;

namespace EmployeeManagement.ViewModels
{
    public class EmployeeCreateViewModel
    {
       
        //   [Required(ErrorMessage = "Please provide a value for Name field")]
        [Required, MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Office Email")]
        [RegularExpression(@"^[a-zA-Z]+[a-zA-Z0-9]+[[a-zA-Z0-9-_.!#$%'*+/=?^]{1,20}@[a-zA-Z0-9]{1,20}.[a-zA-Z]{2,3}$", ErrorMessage = "Invalid email format")]
        public string Email { get; set; }
        [Required]
        public Dept? Department { get; set; }
        public IFormFile Photo { get; set; }
    }
}
