using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        [Required(ErrorMessage = "Please choose profile image")]
        //public string ProfilePicture { get; set; }
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        public ICollection<Enrollment> Enrollments { get; set; }

        //public int ID { get; set; }
        //[Required(ErrorMessage ="Please Enter Your Last Name")]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$",ErrorMessage ="Enter Name Begin with Upper")]
        //[MaxLength(30)]
        //[Display(Name = "Last Name")]
        //public string LastName { get; set; }
        //[Column("FirstName")]
        //[Display(Name ="First Name")]
        //[Required(ErrorMessage = "Please Enter Your First Name")]
        //[MaxLength(30)]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "Enter Name Begin with Upper")]
        //public string FirstMidName { get; set; }
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        //public DateTime EnrollmentDate { get; set; }

        //public ICollection<Enrollment> Enrollments { get; set; }
    }
}
