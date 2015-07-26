using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.Models
{
    [Flags]
    public enum GenderEnum
    {
        男性 = 1,
        女性 = 2,
        中性 = 4
    }

    public class SampleVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Title { get; set; }

        public int Level { get; set; }

        [UIHint("Enum-radio")]
        public GenderEnum Gender { get; set; }
    }
}