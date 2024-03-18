using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercial.Models.Models
{
    public class RegistrationModel
    {
        public int Id { get; set; }
        [Required, MinLength(5), MaxLength(100)]
        public string? Name { get; set; }
        [Required, DataType(DataType.PhoneNumber)]
        public int? Phone { get; set; }
        [Required, EmailAddress]
        public string? Email { get; set; }
        [Required, DataType(DataType.Password), MinLength(5), MaxLength(100)]
        public string? Password { get; set; }
        [Required, DataType(DataType.Password), Compare("Password"), MinLength(5), MaxLength(100)]
        public string? ConfirmPassword { get; set; }
        [Required, MinLength(5), MaxLength(100)]
        public string? CompanyName { get; set; }
        [Required, MinLength(5), MaxLength(1000), DataType(DataType.MultilineText)]
        public string? CompanyLocation { get; set; }
        [Required]
        public string? CompanyLogo { get; set; }
        [Required]
        public string? CompanyCertificateName { get; set; }
    }
}
