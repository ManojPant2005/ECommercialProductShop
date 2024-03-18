using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercial.Models.Models
{
    public class UserRole
    {
        public int Id { get; set; }
        public string? RoleName { get; set; }
        public int UserId { get; set; }
    }
}
