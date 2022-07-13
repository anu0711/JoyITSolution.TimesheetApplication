using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Model { 

    public class Employeetype
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Employee_type_Id { get; set; }
        public string Employee_Name { get; set; }
        public int Employee_Id { get; set; }
    }
}
