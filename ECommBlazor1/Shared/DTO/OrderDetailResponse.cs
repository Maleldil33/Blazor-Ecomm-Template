﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommBlazor1.Shared.DTO
{
    public class OrderDetailsResponse
    {
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public List<OrderDetailsProductResponse> Products { get; set; }
    }
}
