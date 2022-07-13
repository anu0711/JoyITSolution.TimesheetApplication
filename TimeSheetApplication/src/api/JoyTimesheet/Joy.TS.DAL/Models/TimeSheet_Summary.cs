using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Model
{
        public class Timesheet_Summary
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Timesheet_SummaryId { get; set; }

            [ForeignKey("Employee_Id")]
            public int Employee_Id { get; set; }

            [DataType(DataType.Date)]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/DD/YYYY}")]
            public string Month_Year { get; set; }
            public double NoOfdays_Worked { get; set; }
            public double NoOfLeave_Taken { get; set; }
            public double Total_Working_Hours { get; set; }
            public string status { get; set; }
            public bool IsActive { get; set; }
            [DataType(DataType.Date)]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/DD/YYYY}")]
            public string Modified_Date { get; set; }

            [DataType(DataType.Date)]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/DD/YYYY}")]
            public string Created_Date { get; set; }
        }
 }
