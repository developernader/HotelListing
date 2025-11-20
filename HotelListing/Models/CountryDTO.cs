using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models
{
    public class CountryDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 50,ErrorMessage ="Country Name is to log")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 2, ErrorMessage = "Short Country Name is to log")]
        public string ShortName { get; set; }
    }
    public class CreateCountryDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country Name is to log")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 2, ErrorMessage = "Short Country Name is to log")]
        public string ShortName { get; set; }
    }
}
