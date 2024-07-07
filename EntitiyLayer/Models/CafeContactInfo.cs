using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class CafeContactInfo
    {
        public int CafeContactInfoId { get; set; }

        [Required(ErrorMessage ="Mail alanı boş geçilemez.")]
        public String? CafeContactInfoMail { get; set; }

        [Required(ErrorMessage = "Adres alanı boş geçilemez.")]
        public String? CafeContactInfoAddress { get; set; }
    }
}
