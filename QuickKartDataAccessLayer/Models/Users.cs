using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace QuickKartDataAccessLayer.Models
{
    public partial class Users
    {
        public Users()
        {
            Cart = new HashSet<Cart>();
            PurchaseDetails = new HashSet<PurchaseDetails>();
            Rating = new HashSet<Rating>();
        }
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Invalid email address.")]
        [Required(ErrorMessage = "EmailId is mandatory.")]
        [DisplayName("Email Id")]
        public string EmailId { get; set; }
        [StringLength(maximumLength: 10)]
        [Required(ErrorMessage = "Password is mandatory.")]
        [DisplayName("User password")]
        public string UserPassword { get; set; }
        [ScaffoldColumn(false)]
        public Nullable<byte> RoleId { get; set; }
        [Required(ErrorMessage = "Gender is mandatory.")]
        [RegularExpression("^M$|^F$", ErrorMessage = "Gender should be M or F")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "DOB is mandatory.")]
        [DataType(DataType.Date)]
        [DisplayName("Date of birth")]
        public System.DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Address is mandatory.")]
        public string Address { get; set; }






        public Roles Role { get; set; }
        public ICollection<Cart> Cart { get; set; }
        public ICollection<PurchaseDetails> PurchaseDetails { get; set; }
        public ICollection<Rating> Rating { get; set; }
    }
}
