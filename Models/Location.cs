using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stackspite.Models{
    public class Location{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id {get; set;}

        public string AddressLine1 {get; set;}
        public string AddressLine2 {get; set;}
        public string StateCode {get; set;}
        public string PostalCode {get; set;}
        public string Country {get; set;}
        public string ContactPhone {get; set;}
        public string ContactName {get; set;}
        public string ContactEmail{get;set;}
        //Foreign Key
        public string ApplicationUserId {get; set;}

        [ForeignKey("ApplicationUserId")]
        public virtual ApplicationUser ResponsibleUser {get; set;}

    }
}