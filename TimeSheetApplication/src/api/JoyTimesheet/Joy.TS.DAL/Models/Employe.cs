using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Model
{
    public class Employe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Employee_Id { get; set; }
        public string Name { get; set; }
        public int EmployeeNo { get; set; }
        public string Reporting_Manager1 { get; set; }
        public string Reportinng_Manager2 { get; set; }
        public string Type { get; set; }
        public string Email { get; set; }
        [ForeignKey("Role_Id")]
        public int Role_Id { get; set; }
        [ForeignKey("Designations_Id")]
        public int Designations_Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/DD/YYYY}")]
        public string Joining_Date { get; set; }
        public int Contact_No { get; set; }
        public bool Isactive { get; set; }
        public DateTime Create_Date { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/DD/YYYY}")]
        public string Modified_Date { get; set; }
    }
}
