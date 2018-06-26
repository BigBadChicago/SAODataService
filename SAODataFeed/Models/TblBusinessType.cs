using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SAODataFeed.Models {
    [Table("tblBusinessType")]
    public class TblBusinessType {
        public TblBusinessType() {
            this.TblMerchants = new HashSet<TblMerchant>();
            this.TblUdfMasters = new HashSet<TblUdfMaster>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public short ID { get; set; }
        [MaxLength(30)]
        [Required]
        public string BusinessType { get; set; }
        public bool? IsDefault { get; set; }
        public bool? AllowAddMerchByUW { get; set; }
        [Required]
        public bool AssignDMByRegion { get; set; }


        public ICollection<TblMerchant> TblMerchants { get; set; }
        public ICollection<TblUdfMaster> TblUdfMasters { get; set; }

    }
}