using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class FormModel
    {

        [Required]
        [Display(Name = "Ilosc powtorzen")]
        public int Iterations { get; set; }

        [Display(Name = "Imie")]
        [Required]
        public string Name { get; set; }

    }
}
