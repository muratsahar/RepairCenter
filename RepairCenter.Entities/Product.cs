﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairCenter.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SpareParts> SpareParts { get; set; }
    }
}