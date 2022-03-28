﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace ResumeManager.Models
{
    public class Experience
    {
        public Experience()
        {
        }

        [Key]
        public int ExperienceId { get; set; }

        [ForeignKey("Applicant")]//very important
        public int ApplicantId { get; set; }
        public virtual Applicant Applicant { get; private set; } //very important 

        public string CompanyName { get; set; }
        public string Designation { get; set; }   
        
       
        [Required]
        [Range(1, 25, ErrorMessage = "Years must be between 1 and 25")]
        public int YearsWorked { get; set; }


    }
}
