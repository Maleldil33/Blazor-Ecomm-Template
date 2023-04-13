using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommBlazor1.Shared.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public byte[]? PasswordHash { get; set; }

        public byte[]? PasswordSalt { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;

    }
}
