namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN")]
    public partial class ADMIN
    {
        public int Id { get; set; }

        [StringLength(255)]
		[Required(ErrorMessage = "Vui lòng nhập vào tên!")]
		public string Name { get; set; }

        [StringLength(255)]
		[Required(ErrorMessage = "Vui lòng nhập vào tài khoản!")]
		public string Username { get; set; }

        [StringLength(255)]
		[Required(ErrorMessage = "Vui lòng nhập vào mật khẩu!")]
		public string Password { get; set; }

        public string Avatar { get; set; }
    }
}
