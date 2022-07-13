using Employee.Model;
using Joy.TS.BAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Joy.TS.BAL.Implementation
{
    public interface IAdmin
    {
        IEnumerable<ProjectClientModel> GetClient(int id);
    }
}
