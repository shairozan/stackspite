using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Collections.Generic;

namespace stackspite.Models{
    public class Switch : NetworkDevice {

        public Switch(){
            BoardCount = 1; //Default to 1. Not until Enterprise class or stacks you see more than one
        }

        public int BoardCount {get; set;}
        public int InterfacesPer {get; set;}

        //Layer 2 or 3 switch
        public int LayerofOperation{get; set;}


    }
}