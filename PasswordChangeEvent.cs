using System;
namespace Simplification;

public class PasswordChangeEvent : EventBase
{

    public PasswordChangeEvent(string id) : base(id) {}

    public override void Process()
    {
        Console.WriteLine($"Customer {Id} changed their password. Sending a confirmation email to the customer.");
    }
}
