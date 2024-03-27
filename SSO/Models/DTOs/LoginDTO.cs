﻿using SSO.BaseSSO.Model;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SSO.Models.DTOs
{
    public class LoginDTO : BaseDTO
    {
        [Required(ErrorMessage ="نام کاربری الزامی است")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "رمز کاربری الزامی است")]
        [PasswordPropertyText]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        //[Compare(nameof(Password))]
        //public string ConfirmPassword { get; set; }
    }
}
