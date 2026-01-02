namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOCVIEN")]
    public partial class HOCVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOCVIEN()
        {
            BIENLAIs = new HashSet<BIENLAI>();
        }

        [Key]
        [StringLength(10)]
        public string MAHV { get; set; }

        [Required]
        [StringLength(20)]
        public string HO { get; set; }

        [Required]
        [StringLength(30)]
        public string TEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime NTNS { get; set; }

        [StringLength(50)]
        public string NNGHIEP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BIENLAI> BIENLAIs { get; set; }
    }
}
