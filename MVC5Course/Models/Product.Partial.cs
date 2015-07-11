namespace MVC5Course.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product
    {
    }
    
    public partial class ProductMetaData
    {
        [Required]
        public int ProductId { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string ProductName { get; set; }
        [Required]
        public Nullable<decimal> Price { get; set; }
        public Nullable<bool> Active { get; set; }
        [Required]
        public Nullable<decimal> Stock { get; set; }
    
        public virtual ICollection<OrderLine> OrderLine { get; set; }
    }
}
