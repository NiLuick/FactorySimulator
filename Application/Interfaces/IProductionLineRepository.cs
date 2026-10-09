using Domain;

namespace Application.Interfaces;

public interface IProductionLineRepository
{
    Line GetLine();
    Line AddMachine(Machine machine);
}