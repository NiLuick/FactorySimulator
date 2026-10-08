namespace Domain;

/// <summary>
/// Domain Object for a Machine
/// </summary>

public class Machine
{
    public int Id { get; set; }
    public MachineType MachineType { get; set; }
    public decimal Price { get; set; }
    
    public Machine (int id, MachineType machineType, decimal price)
    {
        Id = id;
        MachineType = machineType;
        Price = price;
    }
}