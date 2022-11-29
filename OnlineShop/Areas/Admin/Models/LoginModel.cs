using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "yêu cầu nhập Username")]
        [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage = "Username chứa các kí tự không hợp lệ")]
        public string Username { get; set; }
        [Required(ErrorMessage = "yêu cầu nhập Password")]
        [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage = "Password chứa các kí tự không hợp lệ")]
        public string Password { get; set; }
    }
}