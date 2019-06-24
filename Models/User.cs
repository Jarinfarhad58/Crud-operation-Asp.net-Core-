using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Star_Academy.Models
{
    public partial class User
    {
        [Key]
        public int UserID { get; set; }
        [DisplayName("User Name")]
        [Required(ErrorMessage = "This Field is Required")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This Field is Required")]
        public string Password { get; set; }

      

        
    }
}
