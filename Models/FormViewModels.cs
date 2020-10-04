using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    public class FormViewModels
    {
    }

    public class FromOneViewModel
    { 
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int ID { get; set; }

    }
}