using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DavidToveyTestProject.Models
{
    public class Students
    {
        #region properties

        //<summary>
        //Unique identifier for the student
        //</summary>
        [Key]
        [Required]
        public int Id { get; set; }

        //<summary>
        //First name for the student
        //</summary>
        [Column("first_name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        //<summary>
        //Last name for the student
        //</summary>
        [Column("last_name")]
        [Display(Name = "Last Name")]

        public string LastName { get; set; }
        //<summary>
        //Date of Birth for the student
        //</summary>
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date, ErrorMessage = "Date only")]
        public DateTime Dob { get; set; }

        [Column("year_of_study")]
        [Display(Name = "Year of Study")]

        public string YearOfStudy { get; set; }
        #endregion
    }
}
