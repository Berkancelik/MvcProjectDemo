﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public bool Status { get; set; }

        public ICollection<Heading> Headings { get; set; }
    }
}
