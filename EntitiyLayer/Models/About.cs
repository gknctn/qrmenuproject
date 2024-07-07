using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class About
    {
        public int AboutId { get; set; }
        [Required(ErrorMessage = "Hakkımızda açıklama alanı boş geçilemez.")]
        public string? AboutDescription { get; set; }

        [Required(ErrorMessage = "Hakkımızda vizyon alanı boş geçilemez.")]
        public string? AboutVision { get; set; }

        [Required(ErrorMessage = "Hakkımızda misyon alanı boş geçilemez.")]
        public string? AboutMission { get; set; }

        [Required(ErrorMessage = "Whatsapp numara alanı boş geçilemez.")]
        public string? AboutWpAddress { get; set; }

        [Required(ErrorMessage = "Instagram adres alanı boş geçilemez.")]
        public string? AboutInstagramAddress { get; set; }

        [Required(ErrorMessage = "Facebook adres alanı boş geçilemez.")]
        public string? AboutFacebookAddress { get; set; }
    }
}