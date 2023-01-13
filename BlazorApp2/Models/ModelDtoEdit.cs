using BlazorApp2.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Models
{
    public class ModelDtoEdit : IModelDto
    {
        [Display(Name = "Model's Id (edit)")]
        [Required(ErrorMessage = "Id is required [edit]")]
        public int? Id { get; set; }

        [Display(Name = "Model's description [edit]")]
        [Required(ErrorMessage = "Model's description is required [edit]")]
        [StringLength(2, ErrorMessage = "Model's description too long (2 char). [edit]")]
        public string? Description { get; set; }
    }
}
