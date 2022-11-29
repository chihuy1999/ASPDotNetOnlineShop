using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class ForgotPassModel
    {
        [Required(ErrorMessage = "yêu cầu nhập Username")]
        [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage = "Username chứa các kí tự không hợp lệ")]
        public string Username { get; set; }
        [Required(ErrorMessage = "yêu cầu nhập Gmail")]
        [RegularExpression("[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage = "Gmail chứa các kí tự không hợp lệ")]
        public string Gmail { get; set; }
    }
}