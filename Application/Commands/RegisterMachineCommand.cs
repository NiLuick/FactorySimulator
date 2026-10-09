using Application.CQRSInterfaces;
using Domain;

namespace Application.Commands;

/// <summary>
/// Command for registering a Machine into a Production Line
/// </summary>

public record RegisterMachineCommand(Machine Machine) : ICommand;