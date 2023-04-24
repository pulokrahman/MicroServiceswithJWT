using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Core.Entities
{
    public class Interview
    {
        public int InterviewId { get; set; }
        public int RecruiterId { get; set; }
        public int SubmissionId { get; set; }
        public int InterviewTypeCode { get; set; }
        public int InterviewRound { get; set; }
        public DateTime? ScheduledOn { get; set; }
        public int InterviewerId { get; set; }
        public int FeedbackId { get; set; }

        public Recruiter? Recruiter { get; set; }
        public InterviewType? InterviewType { get; set; }
        public Interviewer? Interviewer { get; set; }
        public InterviewFeedback? InterviewFeedback { get; set; }


    }
}
