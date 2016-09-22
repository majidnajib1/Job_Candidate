using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Job_Candidate.Models
{
    public class Application
    {

        public int ApplicationID { get; set; }

        public int CandidateID { get; set; }

        public int JobID { get; set; }

        public DateTime DateApplied { get; set; }


        public virtual Candidate Candidate { get; set; }

        public virtual Job Job { get; set; }
    }
}