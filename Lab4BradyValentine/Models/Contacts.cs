using System.ComponentModel.DataAnnotations;
namespace Lab4BradyValentine.Models
{
    public class Contact
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "Please enter a lastname.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter a lastname.")] 
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)] 
        public string PhoneNumber { get; set; }

        public virtual Category category { get; set; }
    }
}

