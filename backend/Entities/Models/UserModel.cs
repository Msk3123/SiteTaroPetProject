using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entities.Models;

public class User
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Username is required")]
    [MaxLength(30, ErrorMessage = "Maximum length for the Username is 30 characters.")]
    public string Username { get; set; }
    
    public string PasswordHash { get; set; }
    
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    public string Email { get; set; }
    
}