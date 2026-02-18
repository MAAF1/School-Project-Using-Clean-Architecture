using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Entites
{
    public class DepartmentSubject
    {
        [Key]
        public int DeptSubID { get; set; }
        public int DID {  get; set; }
        public int SubID { get; set; }

        [ForeignKey(nameof(DID))]
        public virtual Department Department { get; set; }

        [ForeignKey(nameof(SubID))]

        public virtual Subjects Subjects { get; set; }

    }
}
