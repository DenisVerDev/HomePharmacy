using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomePharmacy.Models;
using HomePharmacy.Forms;

namespace HomePharmacy
{
    public static class DBValidation
    {
        // error message state is different on each validation method call
        public static string? ValidationErrorMsg { get; private set; }

        #region Person Validation

        public struct PersonValidation
        {
            public const int email_maxsize = 100;
            public const int email_minsize = 6;

            public const int password_maxsize = 16;
            public const int password_minsize = 8;

            public const int name_maxsize = 200;

            public static string[] sexTypes = { "male", "female", "other" };

            public static bool Email(string email)
            {
                if (email == null || email == String.Empty)
                {
                    ValidationErrorMsg = "Email must not be empty!";
                    return false;
                }

                if (email.Length < email_minsize || email.Length > email_maxsize)
                {
                    ValidationErrorMsg = $"Email must be {email_minsize}-{email_maxsize} characters long!";
                    return false;
                }

                if (!email.Contains('@') || !email.Contains('.'))
                {
                    ValidationErrorMsg = $"Email must contain '@' and '.' symbols!";
                    return false;
                }

                return true;
            }

            public static bool Password(string password)
            {
                if (password == null || password == String.Empty)
                {
                    ValidationErrorMsg = "Password must not be empty!";
                    return false;
                }

                if (password.Length < password_minsize || password.Length > password_maxsize)
                {
                    ValidationErrorMsg = $"Password must be {password_minsize}-{password_maxsize} characters long!";
                    return false;
                }

                return true;
            }

            public static bool Name(string name)
            {
                if (name == null || name == String.Empty)
                {
                    ValidationErrorMsg = "Name must not be empty!";
                    return false;
                }

                if (name.Length > name_maxsize)
                {
                    ValidationErrorMsg = $"Name's length must be less than {name_maxsize} characters!";
                    return false;
                }

                return true;
            }

            public static bool Sex(string sex)
            {
                if (sex == null || !sexTypes.Any(x=>x.Equals(sex)))
                {
                    ValidationErrorMsg = "Incorrect sex type!";
                    return false;
                }

                return true;
            }

            public static bool Validate(Person person)
            {
                if (person != null) return Email(person.Email) && Password(person.Password) && Name(person.Name) && Sex(person.Sex);

                ValidationErrorMsg = "Received person is empty!";

                return false;
            }
        }

        #endregion

        #region Illness Validation

        public struct IllnessValidation 
        {
            public const int diagnosis_maxsize = 200;

            public static bool Diagnosis(string diagnosis)
            {
                if (diagnosis == null || diagnosis == String.Empty)
                {
                    ValidationErrorMsg = "Diagnosis must not be empty!";
                    return false;
                }

                if (diagnosis.Length > diagnosis_maxsize)
                {
                    ValidationErrorMsg = $"Diagnosis length must be less than {diagnosis_maxsize} characters!";
                    return false;
                }

                return true;
            }

            public static bool Dates(DateTime start, DateTime? end)
            {
                if (end != null && end <= start)
                {
                    ValidationErrorMsg = "End date must be later than the start date!";
                    return false;
                }

                return true;
            }

            public static bool Validate(Illness illness)
            {
                if (illness != null) return Diagnosis(illness.Diagnosis) && Dates(illness.StartDate, illness.EndDate);

                ValidationErrorMsg = "Received illness is empty!";

                return false;
            }
        }

        #endregion

        #region Appointment Validation

        public struct AppointmentValidation
        {
            public const int recommendator_maxsize = 200;
            public const int info_maxsize = 1000;

            public static bool Recommendator(string recommendator)
            {
                if (recommendator == null || recommendator == String.Empty)
                {
                    ValidationErrorMsg = "Recommendator must not be empty!";
                    return false;
                }

                if (recommendator.Length > recommendator_maxsize)
                {
                    ValidationErrorMsg = $"Recommendator's length must be less than {recommendator_maxsize} characters!";
                    return false;
                }

                return true;
            }

            public static bool MedicineData(string medicines, string med_usage_schedule)
            {
                if (medicines == null || medicines == String.Empty)
                {
                    ValidationErrorMsg = "Medicine list must not be empty!";
                    return false;
                }

                if (med_usage_schedule == null || med_usage_schedule == String.Empty)
                {
                    ValidationErrorMsg = "Medicine usage schedule must not be empty!";
                    return false;
                }

                if (medicines.Length > info_maxsize || med_usage_schedule.Length > info_maxsize)
                {
                    ValidationErrorMsg = $"Medicine list and usage schedule must be lesser than {info_maxsize} characters!";
                    return false;
                }

                return true;
            }

            public static bool Validate(Appointment app)
            {
                if (app != null) return Recommendator(app.Recommendator) && MedicineData(app.Medicines, app.MedicinesUsageSchedule);

                ValidationErrorMsg = "Received appointment is empty!";

                return false;
            }
        }

        #endregion

        #region Medicine Validation

        public struct MedicineValidation
        {
            public const int name_maxsize = 200;
            public static string[] types = { "tablet", "capsules", "liquid", "drops", "inhaler", "injection", "cream", "ointment", "other" };

            public static bool Name(string name)
            {
                if (name == null || name == String.Empty)
                {
                    ValidationErrorMsg = "Medicine's name must not be empty!";
                    return false;
                }

                if (name.Length > name_maxsize)
                {
                    ValidationErrorMsg = $"Medicine's name must be lesser than {name_maxsize} characters!";
                    return false;
                }

                return true;
            }

            public static bool Type(string type)
            {
                if (type == null || !types.Any(x=>x.Equals(type)))
                {
                    ValidationErrorMsg = "Incorrect medicine type!";
                    return false;
                }

                return true;
            }

            public static bool Integers(int count, int excount, int rem)
            {
                if (!(count > 0 && excount > 0 && rem >= 0))
                {
                    ValidationErrorMsg = "Count and Exemplears count must always be more than 0! Remainings can be 0!"; 
                    return false;
                }

                if (rem > count * excount)
                {
                    ValidationErrorMsg = "Remainings can't be more than you can possibly have!";
                    return false;
                }

                return true;
            }

            public static bool Validate(Medicine med)
            {
                if (med != null) return Name(med.Name) && Type(med.Type) && Integers(med.CountOrAmount, med.ExemplearsCount, med.Remainings);

                ValidationErrorMsg = "Received medicine is empty!";

                return false;
            }
        }

        #endregion

        #region MedicineUsage Validation

        public struct MedicineUsageValidation
        {
            public const int comment_maxsize = 1000;
            public static string[] results = { "helps", "does not help", "no opinion" };

            public static bool UsageResult(string result)
            {
                if (result == null || !results.Any(x=>x.Equals(result)))
                {
                    ValidationErrorMsg = "Incorrect usage result!";
                    return false;
                }

                return true;
            }

            public static bool CountOrAmount(ActionType action, MedicinesUsage usage, Medicine medicine)
            {
                if (action == ActionType.ADD && usage.CountOrAmount > medicine.Remainings)
                {
                    ValidationErrorMsg = "You can't use more than you have!";
                    return false;
                }

                if (action == ActionType.UPDATE && usage.CountOrAmount > medicine.CountOrAmount * medicine.ExemplearsCount)
                {
                    ValidationErrorMsg = "You can't use more than you can possiby have!";
                    return false;
                }

                return true;
            }

            public static bool Comment(string comment)
            {
                if (comment != null && comment.Length > comment_maxsize)
                {
                    ValidationErrorMsg = $"Comment's length must be less than {comment_maxsize} characters!";
                    return false;
                }

                return true;
            }

            public static bool Validate(ActionType action, MedicinesUsage usage, Medicine medicine)
            {
                if (usage != null && medicine != null) return UsageResult(usage.UsageResult) && CountOrAmount(action, usage, medicine) && Comment(usage.Comment);

                ValidationErrorMsg = "Received usage is empty!";

                return false;
            }
        }

        #endregion
    }
}
