﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Decription  { get; set; }
        public bool Status { get; set; }
    }
}
