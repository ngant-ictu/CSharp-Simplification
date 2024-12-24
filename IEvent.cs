namespace Simplification;
public interface IEvent
{
    long GetTimeStamp(); // Using long to represent a timestamp
    void Process();
}
