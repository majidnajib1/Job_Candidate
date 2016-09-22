using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Job_Candidate.Models
{
    public class Job
    {

        public int JobID { get; set; }


        [Required (ErrorMessage = "Job Title Required")]
        public string Job_Title { get; set; }


        [Required(ErrorMessage = "Job Summary Required")]
        public String Job_Summary { get; set; }

        [Required(ErrorMessage = "Job Salary Required")]
        public string Salary { get; set; }

        public virtual ICollection<Application> Applications { get; set; }

    }
}