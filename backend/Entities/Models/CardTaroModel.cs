using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class CartTaro
{
    [Column("CartTaroId")]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Cart Taro Name is required")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "Cart Taro Description is required")]
    public string UprightMeaning { get; set; }   // Значення у прямому положенні
    
    [Required(ErrorMessage = "Cart Taro Description is required")]
    public string ReversedMeaning { get; set; }  // Значення у перевернутому положенні
    
    [Required(ErrorMessage = "Cart Taro Description is required")]
    public string Keywords { get; set; } //Ключові слова 
    
}