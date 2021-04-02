using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ParkQuest.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    [Required]
    public string Name { get; set; }
    [StringRange(AllowableValues = new[] { "State", "National" })]
    public string ParkType { get; set; }
    [StringRange(AllowableValues = new[] { "Yes", "No", "Unknown" })]
    public string HasRestrooms { get; set; }
  }

  public class StringRangeAttribute : ValidationAttribute
  {
    public string[] AllowableValues { get; set; }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (AllowableValues?.Contains(value?.ToString()) == true)
        {
            return ValidationResult.Success;
        }

        var msg = $"Please enter one of the allowable values: {string.Join(", ", (AllowableValues ?? new string[] { "No allowable values found" }))}.";
        return new ValidationResult(msg);
    }
  }
}