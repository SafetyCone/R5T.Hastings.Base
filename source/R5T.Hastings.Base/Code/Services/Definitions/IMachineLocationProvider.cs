using System;

using R5T.Delos;

using R5T.T0064;


namespace R5T.Hastings
{
    [ServiceDefinitionMarker]
    public interface IMachineLocationProvider : IServiceDefinition
    {
        MachineLocation GetMachineLocation();
    }
}
