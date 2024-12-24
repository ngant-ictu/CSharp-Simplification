using System;
namespace Simplification;

public class MissedPaymentEvent : EventBase
{
    public MissedPaymentEvent(string id) : base(id) { }

    public override void Process()
    {
        Console.WriteLine($"Customer {Id} missed their payment. Sending a bill to the customer.");
    }
}
