
using Interview.Core.Contracts.Repositories;
using Interview.Core.Entities;
using Interview.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Infrastructure.Repositories
{
    public class InterviewTypeRepository : BaseRepository<InterviewType>, IInterviewTypeRepository
    {
        public InterviewTypeRepository(InterviewDbContext dbContext) : base(dbContext)
        {
        }
    }
}
