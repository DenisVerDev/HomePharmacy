using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomePharmacy.Models;

namespace HomePharmacy
{
    public static class DBValidation
    {
        // error message state is different on each validation method call
        public static string? ValidationErrorMsg { get; private set; }

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

        #region Illness validation
        public struct IllnessValidation
        { 
            public static bool DiagnoseValidation(string diagnose)
            {
                if(diagnose == null || diagnose == String.Empty)
                {
                    ValidationErrorMsg = "Diagnose must not be empty!";
                    return false;
                }

                return true;
            }

            public static bool DateValidation(DateTime start, DateTime? end)
            {
                if(end != null)
                {
                    if(end <= start)
                    {
                        ValidationErrorMsg = "End date must be later than the start date!";
                        return false;
                    }
                }

                return true;
            }
        }


        #endregion

        #region Appointment validation

        public struct AppointmentValidation
        { 
            
            public static bool MedicineListValidation(string meds)
            {
                if(meds == null || meds == String.Empty)
                {
                    ValidationErrorMsg = "Medicine list must not be empty!";
                    return false;
                }

                return true;
            }

            public static bool RecommendatorValidation(string recom)
            {
                if(recom == null || recom == String.Empty)
                {
                    ValidationErrorMsg = "Recommendator must not be empty!";
                    return false;
                }

                return true;
            }
        }

        #endregion

        #region Medicine validation

        public struct MedicineValidation
        {
            public static MedicinesType[] types;

            public static bool Validation(Medicine medicine)
            {
                // name validation
                if (medicine.Name == null || medicine.Name == String.Empty)
                {
                    ValidationErrorMsg = "Medicine name must not be empty!";
                    return false;
                }

                // type validation
                if(!types.Select(x=>x.Type).Contains(medicine.Type))
                {
                    ValidationErrorMsg = "Medicine type is incorrect!";
                    return false;
                }

                if(!(medicine.CountOrAmount > 0 && medicine.ExemplearsCount > 0 && medicine.Remainings >= 0))
                {
                    ValidationErrorMsg = "Medicine count properties are incorrect!";
                    return false;
                }

                if(medicine.Remainings > medicine.CountOrAmount*medicine.ExemplearsCount)
                {
                    ValidationErrorMsg = "Medicine remainings is higher than the max value!";
                    return false;
                }

                return true;
            }
        }
        #endregion
    }
}
