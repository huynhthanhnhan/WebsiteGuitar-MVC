namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MESSAGE")]
    public partial class MESSAGE
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Vui lòng nhập vào tên!")]
        public string Name { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Vui lòng nhập vào email!")]
        public string Email { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(1000)]
        [Required(ErrorMessage = "Vui lòng nhập vào lời nhắn!")]
        public string Message_Content { get; set; }
    }
}
