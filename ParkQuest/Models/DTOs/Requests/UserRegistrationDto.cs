using System.ComponentModel.DataAnnotations;

namespace ParkQuest.Models.DTOs.Requests
{
  public class UserRegistrationDto
  {
    [Required]
    public string UserName { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
  }
}