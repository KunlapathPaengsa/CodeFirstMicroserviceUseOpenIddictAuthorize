using Common.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Member.Models.Tables;

namespace Member.DAL.Repository.Members.Queries
{
    public interface IMemberQueryRepository : IQueryRepository<Models.Tables.Member>
    {
    }
}
