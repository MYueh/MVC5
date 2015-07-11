namespace MVC5Course.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(vwClientSummaryMetaData))]
    public partial class vwClientSummary
    {
    }
    
    public partial class vwClientSummaryMetaData
    {
        [Required]
        public int ClientId { get; set; }
        
        [StringLength(40, ErrorMessage="欄位長度不得大於 40 個字元")]
        public string FirstName { get; set; }
        
        [StringLength(40, ErrorMessage="欄位長度不得大於 40 個字元")]
        public string LastName { get; set; }
        public Nullable<decimal> SumPrice { get; set; }
    }
}
