using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        public int HeadingId { get; set; }

        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public bool Status { get; set; }
        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; }

        public ICollection<Content> Contents { get; set; }
    }
}
