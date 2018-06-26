using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SAODataFeed.Models {
    [Table("tblStatus")]
    public class TblStatus {
        public TblStatus() {
            this.TblMerchants = new HashSet<TblMerchant>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public short ID { get; set; }
        [MaxLength(50)]
        [Required]
        public string Status { get; set; }
        public bool? IsDefault { get; set; }

        public ICollection<TblMerchant> TblMerchants { get; set; }

        [ComplexType]
        public class DBA
        {
            [MaxLength(100)]
            public string Name { get; set; }
        }

        [ComplexType]
        public class DAS
        {
            [MaxLength(50)]
            public string Corp_Name { get; set; }
            [MaxLength(25)]
            public string Status { get; set; }
            [MaxLength(40)]
            public string Addr1 { get; set; }
            [MaxLength(40)]
            public string Addr2 { get; set; }
            [MaxLength(30)]
            public string City { get; set; }
            [MaxLength(5)]
            public string State { get; set; }
            [MaxLength(10)]
            public string Zip { get; set; }
            [MaxLength(10)]
            public string Phone { get; set; }
            [MaxLength(10)]
            public string CR_Review_ID { get; set; }
            public DateTime? Dlr_Active_Dt { get; set; }
        }

        [ComplexType]
        public class Print
        {
            public short? Chain_ID { get; set; }
        }


    }
}