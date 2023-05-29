﻿using System.ComponentModel.DataAnnotations;

namespace Gorev7P013.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        [Display(Name = "Ad"), StringLength(50), Required(ErrorMessage = "{0} Boş Geçilemez!")]
        public string Name { get; set; }
        [Display(Name = "Soyad"), StringLength(50)]
        public string? Surname { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [Display(Name = "Telefon"), StringLength(15)]
        public string? Phone { get; set; }
        [Display(Name = "Mesajınız"), Required(ErrorMessage = "{0} Boş Geçilemez!")]
        public string Message { get; set; }
        [Display(Name = "Eklenme Tarihi"), ScaffoldColumn(false)]
        public DateTime? CreateDate { get; set; } = DateTime.Now;
    }
}
