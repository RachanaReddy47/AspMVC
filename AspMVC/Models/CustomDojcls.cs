using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspMVC.Models
{

    public class CustomDoj : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime D = Convert.ToDateTime(value);
            DateTime td = DateTime.Today;
            int age = (int)td.Subtract(D).TotalDays / 365;
            if (D > td)
                return new ValidationResult("Date cannot be greater than todays date ");
            else if (age < 21 || age > 58)
                return new ValidationResult("age must be b/w 21-58");
            else
                return ValidationResult.Success;

        }

    }
















//    public class CustomDojcls:ValidationAttribute
//    {
//        public override bool IsValid(object value)
//        {
//            DateTime dt = Convert.ToDateTime(value);
//            return dt <= DateTime.Now;
            
//        }        
//        }
//    }
//public class Customage : ValidationAttribute
//{
//    public override bool IsValid(object value)
//    {
//        DateTime dt = Convert.ToDateTime(value);
//        int age = (int)DateTime.Today.Subtract(dt).TotalDays / 365;
//        if (age >= 21 && age<=58)
//            return true;
//        else
//            return false;
//    }
}