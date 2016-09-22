using Job_Candidate.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Job_Candidate
{
    public class Candidate
    {

        public int CandidateID { get; set; }


        [Required(ErrorMessage = "First Name Required")]
        public string FirstName { get; set; }


        [Required (ErrorMessage = "Surname Required")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Date Of Birth Required")]
        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public String Address_Line1 { get; set; }

        [Required]
        public String Town { get; set; }

        [Required]
        public String City { get; set; }

        [Required]
        public String PostCode { get; set; }

        [Required(ErrorMessage = "Phone Number Required")]
      
        public string Mobile { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Personal Statement Required")]
        [DataType(DataType.MultilineText)]
        public string PersonalSatement { get; set; }

        public virtual ICollection<WorkExperience> WorkExpereinces { get; set; }

        public virtual ICollection<Qualification> Qualifications { get; set; }

        public virtual ICollection<Application> Applications { get; set; }

    }

   
}