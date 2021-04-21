using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TelerikBlazorApp2.Models {

    public class DisplayContact {

        public string id { get; set; }

        [Required]
        [StringLength(250,ErrorMessage ="First Name Too Long")]
        [MinLength(1,ErrorMessage ="First Name Too short")]
        public string lastName { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "last Name Too Long")]
        [MinLength(1, ErrorMessage = "last Name Too short")]
        public string firstName { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Phone number Too Long")]
        [MinLength(1, ErrorMessage = "Phone number Too short")]
        public string PhoneNumber { get; set; }
        public DateTime birthDate { get; set; }



    }


}