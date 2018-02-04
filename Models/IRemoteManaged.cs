using System.Collections.Generic;

namespace stackspite.Models.Interfaces{
    public interface IRemoteManaged{

        string Configuration {get; set;}
        string Interface {get; set;}

        Dictionary<int,string> Changes {get; set;}
        
        NetworkDevice.OperationMode Mode {get; set;}

        IRemoteManaged Export();
        IRemoteManaged Enable();

        IRemoteManaged Configure();

        IRemoteManaged SetInterface();

        bool Save();

    }
}