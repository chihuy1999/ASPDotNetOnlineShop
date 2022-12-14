using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class RegisterModel
    {
        [Key]
        public long Id { get; set; }
        [Required(ErrorMessage = "yêu cầu nhập Username")]
        [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage = "Username chứa các kí tự không hợp lệ")]
        public string Username { get; set; }
        [Required(ErrorMessage = "yêu cầu nhập Password")]
        [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage = "Password chứa các kí tự không hợp lệ")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Xác nhận mật khẩu không đúng")]
        public string RepeatPassword { get; set; }
        [Required(ErrorMessage = "yêu cầu nhập họ tên")]
        public string Name { get; set; }
        [Required(ErrorMessage = "yêu cầu nhập địa chỉ")]
        public string Address { get; set; }
        [Required(ErrorMessage = "yêu cầu nhập Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "yêu cầu nhập số điện thoại")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "SDT chứa các kí tự không hợp lệ")]
        public string Phone { get; set; }
    }
}