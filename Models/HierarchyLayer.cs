using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stackspite.Models{
    public class HierarchyLayer{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id {get; set;}

        public string Name {get; set;} //Access, Distribution, or Core
    }
}