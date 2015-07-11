namespace MVC5Course.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(usp_Fabrics_ResultMetaData))]
    public partial class usp_Fabrics_Result
    {
    }
    
    public partial class usp_Fabrics_ResultMetaData
    {
        
        [StringLength(10, ErrorMessage="欄位長度不得大於 10 個字元")]
        [Required]
        public string Table { get; set; }
        public Nullable<int> Count { get; set; }
    }
}
