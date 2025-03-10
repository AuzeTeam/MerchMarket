using Backend.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Backend.DTOs;

public class UserDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string Passwd { get; set; }
    [DefaultValue(false)]
    public bool RememberMe { get; set; }
    
    [DefaultValue(false)]
    public bool LogIn { get; set; }

    [DefaultValue(RoleUser.User)]
    public RoleUser Role { get; set; }
}