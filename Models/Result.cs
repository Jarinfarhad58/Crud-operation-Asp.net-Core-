using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Star_Academy.Models
{
    public partial class Result
    {
        [Key]
        [Required(ErrorMessage = "This Field is Required")]
        [DisplayName("Student Name")]
        public string StudentName { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        [DisplayName("Student ID")]
        public int StudentID { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public Nullable<int> Class { get; set; }
        [DisplayName("Bangla")]
        public string Bngla { get; set; }
        public string English { get; set; }
        [DisplayName("Mathematics")]
        public string Mathmatics { get; set; }
        public string Science { get; set; }
        public string Religion { get; set; }
       
    }
}
