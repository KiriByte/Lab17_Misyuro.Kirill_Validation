using System.ComponentModel.DataAnnotations;
using Lab17_Misyuro.Kirill_Validation.Validators;

namespace Lab17_Misyuro.Kirill_Validation.Models;

public class User
{
    [Key] public int Id { get; set; }
    //[Editable(false)] 
    [Required] public string Name { get; set; }
    [Editable(true)][Required] public string Surname { get; set; }
    [EmailAddress] public string Email { get; set; }
    [Phone] public string Phone { get; set; }
    [AgeValidator(20)] public DateTime DateBirth { get; set; }

    public string StringTest1 { get; set; }
    public string? StringTest2 { get; set; }
    [Required] public string StringTest3 { get; set; }
    [Required] public string? StringTest4 { get; set; }

    [Range(0, 5)] public int RangeValidator { get; set; }

    [RegularExpression(
        @"(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)")]
    public string Ipv4 { get; set; }

    //[CreditCard] public string CreditCard { get; set; }

    [Required] public string Password { get; set; }

    [Compare("Password")] public string ConfirmPassword { get; set; }

    [StringLength(maximumLength: 10, MinimumLength = 5)]
    public string StringLength { get; set; }
}