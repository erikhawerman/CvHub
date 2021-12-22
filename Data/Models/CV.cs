using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
   public class CV
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Visits { get; set; }
        //public System.DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<Education> Educations { get; set; }
        public ICollection<PreviousExperience> PreviousExperience { get; set; }
        public DateTime BirthDate { get; set; }
        public string Creator { get; set; }
    }
}
