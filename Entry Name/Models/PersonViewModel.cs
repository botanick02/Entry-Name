using System.ComponentModel.DataAnnotations;
namespace Entry_Name.Models
{
    public class PersonViewModel
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
    }
}
