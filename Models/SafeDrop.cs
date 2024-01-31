using System.ComponentModel.DataAnnotations.Schema;

namespace IBS.Models
{
    public class SafeDrop : BaseEntity
    {
        [Column(TypeName = "date")]
        public DateTime InvoiceDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime BDate { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        public int CorpCode { get; set; }

        public int SiteCode { get; set; }

        [Column(TypeName = "timestamp without time zone")]
        public DateTime TTime { get; set; }

        [Column(TypeName = "timestamp without time zone")]
        public DateTime Stamp { get; set; }

        [Column(TypeName = "timestamp without time zone")]
        public DateTime Stamp2 { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string CashierId { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string CashierName { get; set; }

        public int Batch { get; set; }

        [Column(TypeName = "numeric(18,2)")]
        public decimal Amount { get; set; }
    }
}