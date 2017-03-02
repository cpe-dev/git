using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPE.DAL.ViewModels
{
   public class AccountViewModel
    {
       [Required(ErrorMessage = "กรุณาระบุชื่อของท่าน")]
       public string FirstName { get; set; }
       [Required(ErrorMessage = "กรุณาระบุนามสกุลของท่าน")]
       public string LastName { get; set; }
       [Required(ErrorMessage = "กรุณาระบุอายุของท่าน")]
       public int Age { get; set; }
       [Required(ErrorMessage = "กรุณาระบุ Username ของท่าน")]
       public string Username { get; set; }
       [Required(ErrorMessage = "กรุณาระบุ Password ของท่าน")]
       public string Password { get; set; }
    }
}
