using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace stackspite.Models{
    public class Make{

        public Make(){
            Active = true;
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id {get; set;}
        public string Name {get; set;}

        public bool Active {get; set;}

        public long ManufacturerId {get; set;}

        [ForeignKey("ManufacturerId")]
        public virtual Manufacturer Manufacturer {get; set;}

        public virtual List<Make> Makes {get; set;}

    }
}