using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Compumatrice_assignment1.Models
{
    [MetadataType (typeof(RegistrationFormMetadata))]
    public partial class tbl_Registrationform
    { 
    
    }
    public sealed class RegistrationFormMetadata
    {
        [Required(ErrorMessage = "User Name is required")]
        [DisplayName("User Name")]
        public string username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DisplayName("Password")]
        public string password { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [CompareAttribute("password", ErrorMessage = "Password doesn't match")]
        [DisplayName("Confirm Password")]
        public string confirmpassword { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [DisplayName("First Name")]
        public string firstname { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [DisplayName("Last Name")]
        public string lastname { get; set; }

        [Required(ErrorMessage = "Email Id is required")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)|False$", ErrorMessage = "Please enter a valid e-mail adress")] 
        [DisplayName("Email Id")]
        public string email { get; set; }

        [Required(ErrorMessage = "Phone no is required")]
        [RegularExpression(@"^\(?([0-9]{1,3})\)?[-. ]?([0-9]{9,14})|False$", ErrorMessage = "Not a valid Phone number.Ex : (091)-9405080880")]
        [DisplayName("Phone No")]
        public string phoneno { get; set; }

        [Required(ErrorMessage = "Location is required")]
        [DisplayName("Location")]
        public string location { get; set; }
    }
}