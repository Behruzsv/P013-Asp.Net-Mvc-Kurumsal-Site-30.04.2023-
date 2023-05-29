using System.ComponentModel.DataAnnotations;

namespace Gorev7P013.Entities
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad Alanı Boş Geçilemez!"), StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez!"), StringLength(50)]
        public string? Surname { get; set; }
        [EmailAddress(ErrorMessage = "Geçersiz Mail Girdiniz!"), StringLength(50)]
        public string? Email { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        public string? UserName { get; set; }
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Display(Name = "Telefon"), StringLength(15)]
        public string? Phone { get; set; }

        [Display(Name = "Eklenme Tarihi"), ScaffoldColumn(false)]
        public DateTime? CreateDate { get; set; } = DateTime.Now;
        [Display(Name = "Durum")]
        public bool IsActive { get; set; }
        [Display(Name = "Admin")]
        public bool IsAdmin { get; set; }
    }
}
