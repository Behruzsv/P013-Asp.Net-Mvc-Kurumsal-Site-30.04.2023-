using System.ComponentModel.DataAnnotations;

namespace Gorev7P013.Entities
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Adı"), StringLength(50)]
        public string Name { get; set; }
        [Display(Name = "Kategori Açıklaması")]
        public string? Description { get; set; }
        [Display(Name = "Eklenme Tarihi")]
        public DateTime? CreatDate { get; set; } = DateTime.Now;
        public virtual List<Product>? Products { get; set; }
    }
}
