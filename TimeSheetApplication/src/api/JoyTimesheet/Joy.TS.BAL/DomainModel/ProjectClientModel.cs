using Employee.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Joy.TS.BAL.DomainModel
{
    public class ProjectClientModel
    {
        public Client client { get; set; }
        public Projects projects { get; set; }
    }
}
