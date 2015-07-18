using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.Models
{
    public class UpdateStockVM
    {
        public int ProductId { get; set; }

        [Required]
        public decimal Stock { get; set; }
    }
}