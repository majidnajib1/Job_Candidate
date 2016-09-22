using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Job_Candidate.Models
{
    public class CandidateContext : DbContext

    {

        public CandidateContext() : base("CandidateContext")
        {

        }

        public DbSet<Candidate> Candidates { get; set; }

        public DbSet<Qualification> Qualifications { get; set; }

        public DbSet<WorkExperience> WorkExperiences { get; set; }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<Application> Applications { get; set; }
    }
}