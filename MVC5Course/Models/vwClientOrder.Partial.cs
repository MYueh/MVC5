namespace MVC5Course.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(vwClientOrderMetaData))]
    public partial class vwClientOrder
    {
    }
    
    public partial class vwClientOrderMetaData
    {
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<decimal> OrderTotal { get; set; }
        
        [StringLength(1, ErrorMessage="欄位長度不得大於 1 個字元")]
        public string OrderStatus { get; set; }
        [Required]
        public int ClientId { get; set; }
        
        [StringLength(40, ErrorMessage="欄位長度不得大於 40 個字元")]
        public string FirstName { get; set; }
        
        [StringLength(40, ErrorMessage="欄位長度不得大於 40 個字元")]
        public string LastName { get; set; }
    }
}
