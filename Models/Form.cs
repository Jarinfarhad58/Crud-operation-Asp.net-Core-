using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Star_Academy.Models
{
    public class Form
    {
        [Key]
            [DisplayName("Form ID")]
            public int FormID { get; set; }
            [Required(ErrorMessage = "This Field is Required")]
            [DisplayName("Student Name")]
            public string StudentName { get; set; }
            [Required(ErrorMessage = "This Field is Required")]
        [DisplayName("Fathers Name")]
        public string FathersName { get; set; }
            [Required(ErrorMessage = "This Field is Required")]
        [DisplayName("Mothers Name")]
        public string MothersName { get; set; }

            public string Village { get; set; }
        [DisplayName("Post Office")]
        public string PostOffice { get; set; }
            public string Thana { get; set; }
            public string Jila { get; set; }
            [Required(ErrorMessage = "This Field is Required")]
            public string Mobile { get; set; }
            [Required(ErrorMessage = "This Field is Required")]
        [DisplayName("Date Of Birth")]
         public string Birthday { get; set; }
        }
    }

