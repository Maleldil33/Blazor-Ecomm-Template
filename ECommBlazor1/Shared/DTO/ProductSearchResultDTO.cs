using ECommBlazor1.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommBlazor1.Shared.DTO
{
    public class ProductSearchResultDTO
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public int Pages { get; set; }
        public int CurrentPage { get; set; }

    }
}
