using System.ComponentModel.DataAnnotations.Schema;

namespace stackspite.Models{
    public class FirewallGroup : DeviceGroup {
        public long FirewallId {get; set;}

        [ForeignKey("FirewallId")]
        public virtual Firewall Firewall {get; set;}
    }
}