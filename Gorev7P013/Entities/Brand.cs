using System.ComponentModel.DataAnnotations;

namespace Gorev7P013.Entities
{
    public class Brand
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad Alanı Boş Geçilemez!"), StringLength(50)]
        public string Name { get; set; }
        [Display(Name = "Açıklama")]
        public string? Description { get; set; }
        [Display(Name = "Eklenme Tarihi"), ScaffoldColumn(false)]
        public DateTime? CreateDate { get; set; } = DateTime.Now;
        [Display(Name = "Logo")]
        public string? Logo { get; set; }
        [Display(Name = "Durum")]
        public bool IsActive { get; set; }
    }
}
