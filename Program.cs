using System;
namespace Simplification;

class Program
{
    static void Main(string[] args)
    {
        IEvent accountTransfer = new AccountTransferEvent("1234");
        IEvent missPayment = new MissedPaymentEvent("5678");
        IEvent passwordChange = new PasswordChangeEvent("91011");

        accountTransfer.Process();
        missPayment.Process();
        passwordChange.Process();
    }
}