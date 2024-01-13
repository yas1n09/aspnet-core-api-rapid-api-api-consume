using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.StaffDto
{
    public class CreateStaffDto
    {
        [Required(ErrorMessage = "Personel Adı Giriniz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Personel Ünvanı Giriniz.")]
        public string Title { get; set; }
        public string SocialMedia1 { get; set; }
        public string SocialMedia2 { get; set; }
        public string SocialMedia3 { get; set; }
    }
}
