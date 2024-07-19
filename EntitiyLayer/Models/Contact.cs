using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Contact
    {
        public int? ContactId { get; set; }

        [Required(ErrorMessage = "Ad alanı boş geçilemez.")]
        public string? ContactName { get; set; }

        [Required(ErrorMessage = "Soyad alanı boş geçilemez.")]
        public string? ContactSurname { get; set; }

        [Required(ErrorMessage = "Mail alanı boş geçilemez.")]
        public string? ContactMail { get; set; }

        [Required(ErrorMessage = "Telefon numarası alanı boş geçilemez.")]
        public string? ContactPhoneNumber { get; set; }

        [Required(ErrorMessage = "Mesaj alanı boş geçilemez.")]
        public string? ContactMessage { get; set; }
        public DateTime ContactDateCreated { get; set; }= DateTime.Now;
    }
}
