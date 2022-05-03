using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public DateTime CreatedDate { get; set; }

        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }
    }
}
