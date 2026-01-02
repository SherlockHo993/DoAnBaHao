namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BIENLAI")]
    public partial class BIENLAI
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MALH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MAHV { get; set; }

        public decimal? DIEM { get; set; }

        [StringLength(10)]
        public string KQUA { get; set; }

        [StringLength(1)]
        public string XEPLOAI { get; set; }

        public decimal? TIENNOP { get; set; }

        public virtual HOCVIEN HOCVIEN { get; set; }

        public virtual LOPHOC LOPHOC { get; set; }
    }
}
