namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOPHOC")]
    public partial class LOPHOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOPHOC()
        {
            BIENLAIs = new HashSet<BIENLAI>();
        }

        [Key]
        [StringLength(10)]
        public string MALH { get; set; }

        [Required]
        [StringLength(70)]
        public string TENLOP { get; set; }

        [Required]
        [StringLength(10)]
        public string MAMH { get; set; }

        [StringLength(10)]
        public string MAGV { get; set; }

        public int LTRG { get; set; }

        public int? SISODK { get; set; }

        [Required]
        [StringLength(10)]
        public string PHHOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BIENLAI> BIENLAIs { get; set; }

        public virtual GIAOVIEN GIAOVIEN { get; set; }
    }
}
