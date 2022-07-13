﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Model
{
    public class TimeSheet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TimeSheet_Id { get; set; }

        [ForeignKey("Employee_Id")]
        public int Employee_Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/DD/YYYY}")]
        public string Day { get; set; }

        public bool Leave { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/DD/YYYY}")]
        public string Date_Time { get; set; }

        [ForeignKey("Project_Id")]
        public int Project_Id { get; set; }

        [ForeignKey("TimesheetSummary_Id")]
        public int TimesheetSummary_Id { get; set; }
    }
}
