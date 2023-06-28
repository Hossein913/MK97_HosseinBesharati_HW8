using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomBMS.Models
{
    public class AuthenticateVM
    {
        [Required]
        [Display(Name="نام کاربری: ")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "رمز عبور: ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
