using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }
        [StringLength(200)]
        public string NameSurname { get; set; }
        [StringLength(150)]
        public string WriterAbout { get; set; }
        [StringLength(1000)]
        public string Image { get; set; }
        [StringLength(200)]
        public string Mail { get; set; }
        [StringLength(200)]
        public string Password { get; set; }
        public ICollection<Heading> Headings { get; set; }
        public ICollection<Content> Contents { get; set; }
    }
}
