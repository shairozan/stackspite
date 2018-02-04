using System.ComponentModel.DataAnnotations.Schema;

namespace stackspite.Models{
    public class SwitchGroup : DeviceGroup {
        public long SwitchId {get; set;}

        [ForeignKey("SwitchId")]
        public virtual Switch Switch {get; set;}
    }
}