namespace Ictshop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nguoidung")]
    public partial class Nguoidung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nguoidung()
        {
            Donhang = new HashSet<Donhang>();
        }

        [Key]
        public int MaNguoiDung { get; set; }

        [StringLength(50)]
        public string Hoten { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Bạn cần nhập email")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Email chưa ký tự không hợp lệ")]
        public string Email { get; set; }

        [StringLength(10)]
        public string Dienthoai { get; set; }

        [StringLength(50)]
        public string Matkhau { get; set; }

        public int? IDQuyen { get; set; }

        [StringLength(100)]
        public string Diachi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Donhang> Donhang { get; set; }

        public virtual PhanQuyen PhanQuyen { get; set; }
    }
}
