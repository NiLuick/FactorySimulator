using Application.Commands;
using Application.CQRSInterfaces;
using Application.Interfaces;

namespace Application.CommandsHandler;

public class RegisterMachineCommandHandler : ICommandHandler<RegisterMachineCommand>
{
    private readonly IProductionLineRepository _productionLineRepository;
    
    public RegisterMachineCommandHandler (IProductionLineRepository productionLineRepository)
    { 
        _productionLineRepository = productionLineRepository;
    }

    // Logic for the Handler
    public void Handle(RegisterMachineCommand command)
    {
        var line = _productionLineRepository.GetLine();
        
        line = _productionLineRepository.AddMachine(command.Machine);
    }
}