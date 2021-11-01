using Common.DAL.Repository;
using Common.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.DAL.Repository.Members.Queries
{
    public class MemberQueryRepository : QueryRepository<Models.Tables.Member>, IMemberQueryRepository
    {
        public MemberQueryRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
