﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.DataAccess.Entities
{
    public class Test
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
