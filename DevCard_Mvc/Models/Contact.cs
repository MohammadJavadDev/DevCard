using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_Mvc.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری است !!!")]
        [MaxLength(100,ErrorMessage = "حداکثر کاراکتر,100 کاراکتر میباشد !!!")]
        [MinLength(3,ErrorMessage = "حداقل کاراکتر,3 کاراکتر میباشد !!!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری میباشد !!!")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده درست نمیباشد !!!")]
        public string Email { get; set; }
        public string Service { get; set; }
        public string Message { get; set; }
    }
}
