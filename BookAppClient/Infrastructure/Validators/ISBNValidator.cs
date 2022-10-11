using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace BookAppSolution.Infrastructure.Validators
{
    public class ISBNValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            ValidationResult result;

            try
            {
                var regex = new Regex(@"^(?=(?:\D*\d){10}(?:(?:\D*\d){3})?$)[\d-]+$");

                bool isValidData = regex.IsMatch(value.ToString());

                result = isValidData ? new ValidationResult(true, null) : new ValidationResult(false, "Ошибка ввода ISBN!");
            }
            catch (Exception)
            {
                result = new ValidationResult(false, "Ошибка ввода ISBN!");
            }
            return result;
        }
    }
}
