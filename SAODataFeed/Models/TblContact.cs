using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SAODataFeed.Models {
    [Table("tblContact")]
    public class TblContact {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; set; }
        [Required]
        public int MerchantID { get; set; }
        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }
        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(50)]
        [Required]
        public string Title { get; set; }
        [MaxLength(50)]
        public string WorkPhone { get; set; }
        public int? WorkPhoneExt { get; set; }
        [MaxLength(20)]
        public string MobilePhone { get; set; }
        [MaxLength(20)]
        public string Fax { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        public bool? DelFlag { get; set; }
        public DateTime? DelDate { get; set; }
        [MaxLength(30)]
        public string DelBy { get; set; }
        public DateTime? CreationDt { get; set; }
        public DateTime? LastUpdatedDt { get; set; }
        [MaxLength(20)]
        public string Salutation { get; set; }
        [Required]
        public bool IsPrimary { get; set; }
        [MaxLength(50)]
        public string CreatedBy { get; set; }
        [MaxLength(50)]
        public string LastUpdatedBy { get; set; }
        [Required]
        public bool IsActive { get; set; }


        public TblMerchant TblMerchant { get; set; }

    }
}