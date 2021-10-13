using System.ComponentModel.DataAnnotations;

namespace Models {
public class Person {

    public int Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string HairColor { get; set; }
    [Required]
    public string EyeColor { get; set; }
    [Required]
    [Range(1,int.MaxValue,ErrorMessage = "Please enter a valid age")]
    public int Age { get; set; }
    [Required]
    [Range(1,int.MaxValue,ErrorMessage = "Please enter a valid weight")]
    public float Weight { get; set; }
    [Required]
    [Range(1,int.MaxValue,ErrorMessage = "Please enter a valid height")]
    public int Height { get; set; }
    [Required]
    public string Sex { get; set; }
}


}