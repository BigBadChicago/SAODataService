using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SAODataFeed.Models {
    [Table("tblIndustry")]
    public class TblIndustry {
        public TblIndustry() {
            this.TblMerchants = new HashSet<TblMerchant>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public short ID { get; set; }
        [MaxLength(50)]
        [Required]
        public string Industry { get; set; }
        public bool? IsDefault { get; set; }
        [Required]
        public bool IsActive { get; set; }


        public ICollection<TblMerchant> TblMerchants { get; set; }

    }
}