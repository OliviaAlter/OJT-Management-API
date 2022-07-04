using System.ComponentModel.DataAnnotations;

namespace ojt_management_api.DTOs;

public class RegisterAccountDto
{
    [Required] public string Username { get; set; }

    [Required] public string Password { get; set; }
}