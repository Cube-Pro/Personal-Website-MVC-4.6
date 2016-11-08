using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Personal_Website_MVC_4._6.Models.HomeViewModels
{
    public class PersonProfile
    {
        public int ProfileID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string BioDetails { get; set; }
        public string BioImagePath { get; set; }
        public string[] SkillsList { get; set; }
        public string[] Awards { get; set; }
        public string PressRelease { get; set; }
        public string Title { get; set; }

    }
}