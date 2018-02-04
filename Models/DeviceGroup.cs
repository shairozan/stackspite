using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stackspite.Models{
    public class DeviceGroup{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id {get; set;}

        public long LocationId {get; set;}

        public string DeviceType {get; set;} //Switch, Router, Firewall
        public long DeviceId {get; set;}

        //Insert public method for reflecting the fuck out of the object. 

    }
}