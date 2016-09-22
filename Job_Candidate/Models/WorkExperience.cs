using System.ComponentModel.DataAnnotations;

namespace Job_Candidate
{
    public class WorkExperience
    {

        public int WorkExperienceID { get; set; }

        [Required]
        public int CandidateID { get; set; }


        [Required(ErrorMessage = "Job Title required")]
        public string JobTitle { get; set; }


        [Required]
        
        public string date_Started { get; set; }


        [Required]
        
        public string date_Ended { get; set; }

        [Required(ErrorMessage = "Job Summary Required")]
        public string Job_Summary { get; set; }


        public virtual Candidate candidate { get; set; }
    }
}