using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stackspite.Models{
    public abstract class NetworkDevice{


        public enum OperationMode
        {
            Read,
            Enable,
            Configure
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id {get; set;}
        public string Name {get; set;}
        public string Address {get; set;}
        public string NetMask {get; set;}
        public string Gateway {get; set;}

        public string AccessMethod {get; set;}
        public string Username {get; set;} 
        public string Password {get; set;} //Encrypted Value
        public string ExecPassword {get; set;} //Encrypted Value

        //"term pager 0" for ASAs
        public string TermIndicator {get; set;}

        public long HierarchyLayerId {get; set;}
        

        public DateTime CreatedAt {get; set;}
        public DateTime UpdatedAt {get; set;}

        public virtual HierarchyLayer HierarchyLayer {get; set;}
    }
}