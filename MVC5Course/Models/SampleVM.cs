using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.Models
{
    public class SampleVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Title { get; set; }

        public int Level { get; set; }
    }
}