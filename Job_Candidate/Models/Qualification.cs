using System.ComponentModel.DataAnnotations;

namespace Job_Candidate
{
    public class Qualification
    {

        public int QualificationID { get; set; }


        [Required]
        public int CandidateID { get; set; }


        [Required (ErrorMessage = "Qualification Title required")]
        public string Title { get; set; }


        [Required]
        
        public string date { get; set; }


        [Required (ErrorMessage ="Grade Required")]
        public string Grade { get; set; }


        public virtual Candidate candidate { get; set; }

    }
}