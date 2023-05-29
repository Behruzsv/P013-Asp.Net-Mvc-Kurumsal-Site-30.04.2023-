using System.ComponentModel.DataAnnotations;

namespace Gorev7P013.Entities
{
    public class Slider
    {
        public int Id { get; set; }
        [Display(Name = "Resim"), StringLength(50)]
        public string? Image { get; set; }
    }
}

