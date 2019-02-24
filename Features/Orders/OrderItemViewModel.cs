﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Packt1.Features.Orders
{
    public class OrderItemViewModel
    {
        public int ProductId { get; set; }
        public int ColourId { get; set; }
        public int StorageId { get; set; }
        public int Quantity { get; set; }
    }
}
