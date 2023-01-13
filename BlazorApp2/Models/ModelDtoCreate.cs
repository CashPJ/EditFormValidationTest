using BlazorApp2.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Models
{
    public class ModelDtoCreate : IModelDto
    {
        [Display(Name = "Model's Id [create]")]        
        public int? Id { get; set; }

        [Display(Name = "Model's description [create]")]
        [Required(ErrorMessage = "Model's description is required [create]")]
        [StringLength(2, ErrorMessage = "Model's description too long (2 char). [create]")]
        public string? Description { get; set; }
    }
}
