using System.ComponentModel.DataAnnotations.Schema;

namespace stackspite.Models{
    public class RouterGroup : DeviceGroup{
        public long RouterId {get;set;}

        [ForeignKey("RouterId")]
        public virtual Router Router {get; set;}
    }
}