using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CCSD_Police_Compaint_Form.Models
{
    public class Form
    {
        public enum ComplaintType
        {
            [Description("Use of Force")]
            UseOfForce,
            [Description("Procedure Violation")]
            ProcedureViolation,
            [Description("Property Loss Or Damage")]
            PropertyLossOrDamage,
            [Description("Other")]
            Other
        }

        public int id { get; set; }
        [DisplayName("First Name")]
        [Required(ErrorMessage ="First Name is Required")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; }
        [DisplayName("Location of Incident")]
        [Required(ErrorMessage = "Location of Incident is Required")]
        public string LocationOfIncident { get; set; }
        [DisplayName("Complaint Type")]
        [Required(ErrorMessage = "Complaint Type is Required")]
        public ComplaintType ComplaintTypes { get; set; }
        public string  Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        [DisplayName("Date of Incident")]
        [Required(ErrorMessage = "Date of Incident is Required")]
        
        public DateTime DateOfIncident { get; set; }
        [DisplayName("Date of Birth")]
        public string DateOfBirth { get; set; }
        [Required(ErrorMessage = "Phone Number is Required")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }
        [DisplayName("Name of Employee")]
        public string NameOfEmployees { get; set; }
        [DisplayName("Badge Number")]
        public string BadgeNumber { get; set; }
        [DisplayName("Details to Help Identify Employee")]
        [Column(TypeName = "text")]
        public string DetailsToHelpIdentifyEmployee { get; set; }
        [DisplayName("Summary of Complaint")]
        [Required(ErrorMessage = "Summary of Complaint is Required")]
        [Column(TypeName ="text")]
        public string SummaryOfComplaint { get; set; }
        public string Witnesses { get; set; }



    }
}
