using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Education
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime  StartYear { get; set; }
        public DateTime EndYear { get; set; }
        [Required]
        public string SchoolName { get; set; }
        [Required]
        public string EducationName { get; set; }

        public string Description { get; set; }
        public ApplicationUser User { get; set; }



    }
}
