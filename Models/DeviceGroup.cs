using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stackspite.Models{
    public class DeviceGroup{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id {get; set;}

        public long LocationId {get; set;}

        [ForeignKey("LocationId")]
        public virtual Location Location {get; set;}

    }
}