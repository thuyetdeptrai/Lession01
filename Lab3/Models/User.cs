using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class User
    {
        [Required(ErrorMessage = "Không được để trống!")]
        [Display(Name = "Mã sinh viên")]
        public int id { get; set; }
        [Display(Name = "Tài khoản")]
        [Required(ErrorMessage = "Không được để trống!")]
        [MaxLength(20, ErrorMessage = "Tài khoản từ 6 - 20 ký tự")]
        [MinLength(6, ErrorMessage = "Tài khoản từ 6 - 20 ký tự")]
        public string? username { get; set; }
        [Required(ErrorMessage = "Không được để trống!")]
        [MaxLength(10, ErrorMessage = "Mật khẩu từ 6 - 10 ký tự")]
        [MinLength(6, ErrorMessage = "Mật khẩu từ 6 - 10 ký tự")]
        [Display(Name = "Mật khẩu")]
        public string? password { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Không được để trống!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Sai định dạng email")]
        public string? email { get; set; }
        [Display(Name = "Điện thoại")]
        [Required(ErrorMessage = "Không được để trống!")]
        public string? phone { get; set; }
    }

}
