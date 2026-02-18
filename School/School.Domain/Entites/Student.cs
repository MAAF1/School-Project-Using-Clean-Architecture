using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Entites
{
    public class Student
    {
        [Key]
        public int StudID { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        public string Phone { get; set; }

        public int? DID { get; set; }

        [ForeignKey(nameof(DID))]

        public virtual Department Department { get; set; }
    }
}
