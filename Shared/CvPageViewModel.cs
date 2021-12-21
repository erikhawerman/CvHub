using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Shared
{
    public class CvPageViewModel
    {
        public string email { get; set; }
        public int phoneNumber { get; set; }
        public string profession { get; set; }
        public List<PreviousExperience> previousExperiences { get; set; }
        public string bio { get; set; }
        public List<Project> projects { get; set; }
        public string ExistingImagePath { get; set; }
    }
}
