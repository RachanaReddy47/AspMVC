using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspMVC.Models
{
    public class ValidationCls
    {
        string FirstName;
        string LastName;
        double salary;
        string pancard;
        string password;
        string confirmPassword;
        string phone;
        string email;
        DateTime doj;

        [Required(ErrorMessage ="Firstname is a must")]
        [StringLength(maximumLength:25,ErrorMessage ="Max Length is 25 only")]
        public string FirstName1 { get => FirstName; set => FirstName = value; }
        [Required(ErrorMessage = "Lastname is a must")]
        [StringLength(maximumLength: 25, ErrorMessage = "Max Length is 25 only")]
        public string LastName1 { get => LastName; set => LastName = value; }

        [Required(ErrorMessage = "salary is a must")]
        [Range(10000,200000,ErrorMessage ="Salary must be between in range")]
        public double Salary { get => salary; set => salary = value; }

        [Required(ErrorMessage = "Pancard is a must")]
        [RegularExpression("^[A-Z]{5}[0-9]{4}[A-Z]{1}$", ErrorMessage = "not a valid pancard")]
        public string Pancard { get => pancard; set => pancard = value; }
        [Required(ErrorMessage = "Password is a must")]
        public string Password { get => password; set => password = value; }
        [Compare("Password",ErrorMessage = "Password Mismatch")]
        public string ConfirmPassword { get => confirmPassword; set => confirmPassword = value; }

        [Phone(ErrorMessage = "Not a valid phone number")]
        [MinLength(10, ErrorMessage = "10 digits only")]
        [MaxLength(10, ErrorMessage = "10 digits only")]
        public string Phone { get => phone; set => phone = value; }
        [EmailAddress(ErrorMessage = "Not a valid Email address")]
        public string Email { get => email; set => email = value; }

       
        //[Customage(ErrorMessage = "Age must be b/w 21-58")]
        [CustomDoj(ErrorMessage = "Date ")]
        public DateTime Doj { get => doj; set => doj = value; }
    }
}