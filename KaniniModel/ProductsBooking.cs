﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApiProject.KaniniModel
{
    public partial class ProductsBooking
    {
        public int Productid { get; set; }
        public string Productname { get; set; }
        public int? Productprice { get; set; }
        public string ProductImage { get; set; }
    }
}
