using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace BookAppSolution.Infrastructure.Validators
{
    public class YearValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            ValidationResult result;
            try
            {
                int year;

                bool isValidType = int.TryParse(value.ToString(), out year);

                var regex = new Regex(@"^[12][0-9]{3}$");

                bool isValidData = regex.IsMatch(year.ToString());

                result = isValidType && isValidData ? new ValidationResult(true, null) : new ValidationResult(false, "Ошибка ввода года!");
            }
            catch (Exception)
            {
                result = new ValidationResult(false, "Ошибка ввода года!");
            }
            return result;
        }
    }
}
