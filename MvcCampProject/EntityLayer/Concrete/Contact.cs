using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        [StringLength(200)]
        public string NameSurname { get; set; }
        [StringLength(200)]
        public string Mail { get; set; }
        [StringLength(20)]
        public string Phone { get; set; }
        [StringLength(40)]
        public string Subject { get; set; }
        [StringLength(1000)]
        public string Message { get; set; }
    }
}
