using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationOrnegi.Models
{
    public class Urun
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage="{0} girmek zorundasınız")]
        [Display(Name ="Ürün Kodu")]
        [StringLength(50,ErrorMessage ="{0} maksimum {1} karakterden uzun olamaz.")]
        public string UrunKodu { get; set; }

        [Required(ErrorMessage = "{0} girmek zorundasınız")]
        [Display(Name = "Ürün Tanım")]
        [StringLength(100, ErrorMessage = "{0} maksimum {1} karakterden uzun olamaz.")]
        public string UrunTanim { get; set; }

        [Required(ErrorMessage = "{0} girmek zorundasınız")]
        public int Miktar { get; set; }

        public bool Aktif { get; set; }
        public string AktifString => Aktif ? "Aktif" : "Pasif";
    }
}
