using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace CPE.DAL.ViewModels
{
    public class ContactFormModel
    {
        [Required(ErrorMessage = "กรุณาระบุชื่อ นามสกุลของท่าน")]
        public string Name { get; set; }

        public string PanellistNo { get; set; }

        [Required(ErrorMessage = "กรุณาระบุเบอร์โทรศัพท์ที่สะดวกให้เจ้าหน้าที่ติดต่อกลับ")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "กรุณาระบุอีเมล")]
        public string Email { get; set; }

        [Required(ErrorMessage = " กรุณาระบุที่อยู่")]
        public string Address { get; set; }

        [Required(ErrorMessage = "กรุณาระบุจังหวัดที่ท่านอาศัยอยู่")]
        public string Province { get; set; }

        [Required(ErrorMessage = "กรุณาระบุรหัสไปรษณีย์ให้ถูกต้อง")]
        public string Postcode { get; set; }

        [Required(ErrorMessage = "กรุณาเลือกหัวข้อการติดต่อ")]
        public string Topic { get; set; }

        [Required(ErrorMessage = "กรุณารายละเอียดของการติดต่อ")]
        public string Detail { get; set; }

        public string ContactCaptcha { get; set; }
    }
}
