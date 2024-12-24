using System;
namespace Simplification;

public class AccountTransferEvent : EventBase
{
    public AccountTransferEvent(string id) : base(id) {}

    

    public override void Process()
    {
        Console.WriteLine($"Customer {Id} needs to transfer their service. Reaching out to CTE to remove service form old device and add service to new device");
    }
}
