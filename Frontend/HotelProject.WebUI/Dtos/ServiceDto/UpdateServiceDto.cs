using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }
        [Required(ErrorMessage = "Hizmet İkon Linki Giriniz.")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet Başlığı Giriniz.")]
        [StringLength(100, ErrorMessage = "Hizmet Başlığı Maksimum 100 Karakter Olabilir.")]
        public string ServiceTitle { get; set; }
        [Required(ErrorMessage = "Hizmet Açıklaması Giriniz.")]
        [StringLength(500, ErrorMessage = "Hizmet Açıklaması Maksimum 500 Karakter Olabilir.")]
        public string ServiceDescription { get; set; }
    }
}
