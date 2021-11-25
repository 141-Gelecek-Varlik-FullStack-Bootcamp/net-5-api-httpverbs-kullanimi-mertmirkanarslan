using System;
using System.ComponentModel.DataAnnotations;

namespace Datas
{
    public class User
    {
        // id is going to be our key, so we should use the [key] data annotation
        [Key]
        [Required]
        public int Id { get; set; }
        
        [Required(ErrorMessage ="Adınızı girin.")]
        [MinLength(2), MaxLength(50)]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Soyadınızı girin.")]
        [MinLength(2), MaxLength(50)]
        public string Surname { get; set; }
        
        [Range(typeof(int),"16","80",ErrorMessage ="Kabul edilen yaş aralığı 16 ile 80 arasıdır.")]
        public int Age { get; set; }
        
        [Required(ErrorMessage = "Lütfen e-mail adresinizi girin.")]
        [MinLength(10, ErrorMessage ="E-mail adresiniz 10 karakterden küçük olamaz.")]
        [MaxLength(300, ErrorMessage ="E-mail adresiniz 300 karakterden büyük olamaz.")]
        [EmailAddress(ErrorMessage ="Lütfen geçerli bir e-mail adresi girin.")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Lütfen parola belirleyin.")]
        public string Password { get; set; }

    }
}
