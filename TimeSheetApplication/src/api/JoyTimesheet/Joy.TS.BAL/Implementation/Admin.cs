using Joy.TS.BAL.DomainModel;
using Joy.TS.DAL.Data;
using System.Collections.Generic;
using System.Linq;

namespace Joy.TS.BAL.Implementation
{
    public class Admin : IAdmin
    {
        private readonly TimesheetContext _timesheetContext;

        public Admin(TimesheetContext TSheet)
        {
            _timesheetContext = TSheet;
        }

        public IEnumerable<ProjectClientModel> GetClient(int id)
        {
            return this._timesheetContext.Projects.Join(_timesheetContext.Clients, p => p.Client_id, c => c.Client_Id, (p, c) => new ProjectClientModel
            {
                client = c,
                projects = p
            });
        }

    }
}
