namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DISCOUNT_CODE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DISCOUNT_CODE()
        {
            INVOICE = new HashSet<INVOICE>();
        }

        public int Id { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Vui lòng nhập vào mã giảm giá!")]
        public string Code { get; set; }

		[Required(ErrorMessage = "Vui lòng nhập vào % giảm giá!")]
		public int? Discount_Amount { get; set; }

        [Column(TypeName = "smalldatetime")]
		[Required(ErrorMessage = "Vui lòng nhập vào ngày bắt đầu!")]
		public DateTime? Start_Date { get; set; }

        [Column(TypeName = "smalldatetime")]
		[Required(ErrorMessage = "Vui lòng nhập vào ngày kết thúc!")]
		public DateTime? End_Date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVOICE> INVOICE { get; set; }
    }
}
