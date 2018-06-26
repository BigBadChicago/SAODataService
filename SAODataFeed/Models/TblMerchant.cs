using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SAODataFeed.Models {
    [Table("tblMerchant")]
    public class TblMerchant {
        public TblMerchant() {
            this.TblContacts = new HashSet<TblContact>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; set; }
        [Required]
        public short MerchantTypeID { get; set; }
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        [MaxLength(50)]
        [Required]
        public string Address1 { get; set; }
        [MaxLength(50)]
        public string Address2 { get; set; }
        [MaxLength(50)]
        [Required]
        public string City { get; set; }
        [MaxLength(10)]
        [Required]
        public string State { get; set; }
        [MaxLength(15)]
        [Required]
        public string Zip { get; set; }
        [MaxLength(20)]
        [Required]
        public string Phone { get; set; }
        [MaxLength(20)]
        public string Fax { get; set; }
        [MaxLength(100)]
        public string HomePage { get; set; }
        public decimal? TotalSalesVol { get; set; }
        public decimal? TotalFinVol { get; set; }
        public short? IndustryID { get; set; }
        public short? ProductID { get; set; }
        [Required]
        public short StatusID { get; set; }
        [Required]
        public short ProbOfClosureID { get; set; }
        public short? ActionID { get; set; }
        public short? FinSourceID { get; set; }
        public DateTime? FollowupDate { get; set; }
        [Required]
        public short ReferredByID { get; set; }
        public short? AppProcessingID { get; set; }
        public short? FundProcessingID { get; set; }
        public short? AgreementTypeID { get; set; }
        public short? TermsID { get; set; }
        public short? AffiliationID { get; set; }
        public int? MDN { get; set; }
        [MaxLength(100)]
        [Required]
        public string CorpName { get; set; }
        [MaxLength(50)]
        public string CorpHQ { get; set; }
        [MaxLength(50)]
        [Required]
        public string CorpAddr1 { get; set; }
        [MaxLength(50)]
        public string CorpAddr2 { get; set; }
        [MaxLength(50)]
        [Required]
        public string CorpCity { get; set; }
        [MaxLength(10)]
        [Required]
        public string CorpState { get; set; }
        [MaxLength(15)]
        [Required]
        public string CorpZip { get; set; }
        [MaxLength(20)]
        public string CorpPhone { get; set; }
        public short? LostToID { get; set; }
        public short? WhyLostID { get; set; }
        [Required]
        public short BusinessTypeID { get; set; }
        [MaxLength(30)]
        [Required]
        public string DealerManagerID { get; set; }
        [Required]
        public short CountryID { get; set; }
        public DateTime? DateAdded { get; set; }
        public int? StoreCount { get; set; }
        public bool? DelFlag { get; set; }
        public DateTime? DelDate { get; set; }
        [MaxLength(30)]
        public string DelBy { get; set; }
        public DateTime? CreationDt { get; set; }
        public DateTime? LastUpdatedDt { get; set; }
        public DateTime? SignedDt { get; set; }
        public DateTime? TerminatedDt { get; set; }
        public DBA DBA_CT { get; set; }
        [MaxLength(30)]
        public string SalesAgentID { get; set; }
        [MaxLength(20)]
        public string MerchantNumber { get; set; }
        [MaxLength(75)]
        public string CreatedBy { get; set; }
        [MaxLength(75)]
        public string LastUpdatedBy { get; set; }
        [MaxLength(30)]
        public string GroupHeadID { get; set; }
        public DAS DAS_CT { get; set; }
        public Print Print_CT { get; set; }


        public TblIndustry TblIndustry { get; set; }
        public TblStatus TblStatus { get; set; }
        public TblBusinessType TblBusinessType { get; set; }
        public ICollection<TblContact> TblContacts { get; set; }
        public TblUserAccess TblUserAccess { get; set; }
        public TblUserAccess TblUserAccess1 { get; set; }

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