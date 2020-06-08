namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MANUFACTURER")]
    public partial class MANUFACTURER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MANUFACTURER()
        {
            PRODUCT = new HashSet<PRODUCT>();
        }

        public int Id { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Vui lòng nhập tên thương hiệu!")]
        public string Name { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Vui lòng nhập quốc gia!")]
        public string Country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCT> PRODUCT { get; set; }
    }
}
