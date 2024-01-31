﻿using System.ComponentModel.DataAnnotations.Schema;

namespace IBS.Models
{
    public class Fuel : BaseEntity
    {
        [Column(TypeName = "timestamp without time zone")]
        public DateTime Start { get; set; }

        [Column(TypeName = "timestamp without time zone")]
        public DateTime End { get; set; }

        [Column(TypeName = "date")]
        public DateTime InvoiceDate { get; set; }

        public int CorpCode { get; set; }

        public int SiteCode { get; set; }

        public int Tank { get; set; }

        public int Pump { get; set; }

        public int Nozzle { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        public int Transaction { get; set; }

        [Column(TypeName = "numeric(18,2)")]
        public decimal Price { get; set; }

        //AmountDB = Price * Volume
        [Column(TypeName = "numeric(18,2)")]
        public decimal ActualAmount { get; set; }

        [Column(TypeName = "numeric(18,2)")]
        public decimal Amount { get; set; }

        [Column(TypeName = "numeric(18,2)")]
        public decimal Calibration { get; set; }

        //Volume = Amount / Price
        [Column(TypeName = "numeric(18,2)")]
        public decimal Volume { get; set; }

        [Column(TypeName = "varchar(16)")]
        public string ItemCode { get; set; }

        [Column(TypeName = "varchar(32)")]
        public string Particulars { get; set; }

        public long Opening { get; set; }

        public long Closing { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string NozDown { get; set; }

        [Column(TypeName = "timestamp without time zone")]
        public DateTime InTime { get; set; }

        [Column(TypeName = "timestamp without time zone")]
        public DateTime OutTime { get; set; }

        //Liters = Opening - Closing
        [Column(TypeName = "numeric(18,2)")]
        public decimal Liters { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string CashierId { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string CashierName { get; set; }

        public int Shift { get; set; }

        public int TransCount { get; set; }
    }
}