#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DojoSurvey.Models
{
public class Submit
    {
    [Display(Name= "Name")]
    [Required]
    [MinLength(2, ErrorMessage ="Please input first and last name")]
    public string Name {get;set;}

    [Display(Name ="Location")]
    [Required]
    [MinLength(4, ErrorMessage ="Please choose a location")]
    public string Location {get; set;}

    [Display(Name="Language")]
    [Required]
    [MinLength(4,ErrorMessage ="Please choose a favorite Language")]

        public string Language{get; set;}
    
    [Display(Name="Comment")]
    [MinLength(20, ErrorMessage ="Please give a brief description of 20 characters")]
        public string Comment{get; set;}
    }
}
