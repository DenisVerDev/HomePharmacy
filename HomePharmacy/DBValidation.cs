using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePharmacy
{
    public static class DBValidation
    {
        // error message state is different on each validation method call
        public static string? ValidationErrorMsg { get; private set; }

        public static void ShowValidationError(Label label) => label.Text = ValidationErrorMsg;  

        #region Person validation
        public struct PersonValidation
        {
            public const int emailMinLength = 10;
            public const int passMinLength = 8;
            public const int passMaxLength = 16;
            public const int nameMaxLength = 200;

            public static readonly string[] sexTypes = { "male", "female", "other" };

            public static bool EmailValidation(string email)
            {
                if (email.Length < emailMinLength)
                {
                    ValidationErrorMsg = $"Email address must be at least {emailMinLength} characters long!";
                    return false;
                }

                if (!email.Contains('@'))
                {
                    ValidationErrorMsg = "Email address should contain @ symbol!";
                    return false;
                }

                return true;
            }

            public static bool PasswordValidation(string password)
            {
                if (password.Length < passMinLength || password.Length > passMaxLength)
                {
                    ValidationErrorMsg = $"Password's length must be {passMinLength}-{passMaxLength} characters long!";
                    return false;
                }

                return true;
            }

            public static bool NameValidation(string name)
            {
                if (name == String.Empty)
                {
                    ValidationErrorMsg = "Name field is empty!";
                    return false;
                }

                if (name.Length > nameMaxLength)
                {
                    ValidationErrorMsg = $"Name's length should be less than {nameMaxLength} characters!";
                    return false;
                }

                return true;
            }

            public static bool SexValidation(string sex)
            {
                if (!sexTypes.Any(x => x.Equals(sex)))
                {
                    ValidationErrorMsg = "Sex field value is not valid!";
                    return false;
                }

                return true;
            }
        }
        #endregion
    }
}
