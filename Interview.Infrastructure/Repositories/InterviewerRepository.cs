
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
    public class InterviewerRepository : BaseRepository<Core.Entities.Interviewer>, IInterviewerRepository
    {
        public InterviewerRepository(InterviewDbContext dbContext) : base(dbContext)
        {
        }
    }
}
