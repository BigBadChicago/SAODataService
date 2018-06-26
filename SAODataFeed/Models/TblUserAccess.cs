using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SAODataFeed.Models {
    [Table("tblUserAccess")]
    public class TblUserAccess {
        public TblUserAccess() {
            this.TblMerchants = new HashSet<TblMerchant>();
            this.TblMerchants1 = new HashSet<TblMerchant>();
        }
        [Key]
        [MaxLength(30)]
        [Required]
        public string UserID { get; set; }
        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }
        [Required]
        public short CountryID { get; set; }
        [MaxLength(50)]
        public string CreatedBy { get; set; }
        public DateTime? CreationDt { get; set; }
        [MaxLength(50)]
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDt { get; set; }

 //       [InverseProperty("TblUserAccess")]
        public ICollection<TblMerchant> TblMerchants { get; set; }
 //       [InverseProperty("TblUserAccess")]
        public ICollection<TblMerchant> TblMerchants1 { get; set; }

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