using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public ICollection<ApplicationUser> Users { get; set; }
        public string Description { get; set; }
        public ApplicationUser Creator { get; set; }
    }
}