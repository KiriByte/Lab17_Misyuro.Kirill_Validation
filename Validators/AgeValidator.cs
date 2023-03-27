using System.ComponentModel.DataAnnotations;

namespace Lab17_Misyuro.Kirill_Validation.Validators;

public class AgeValidator : ValidationAttribute
{
    private int _targetAge = 18;
    public AgeValidator() { }
    public AgeValidator(int targetAge)
    {
        _targetAge = targetAge;
    }
    protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
    {
        if ((DateTime)value <= DateTime.Now.AddYears(-_targetAge))
        {
            return ValidationResult.Success;
        }

        return new ValidationResult($"Your age is under {_targetAge}");
    }
}