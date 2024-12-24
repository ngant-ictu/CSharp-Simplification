using System;

namespace Simplification;

public abstract class EventBase : IEvent
{
    public long CreatedTimestamp { get; private set; }
    public string Id { get; private set; }

    public EventBase(string id)
    {
        CreatedTimestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        Id = id;
    }


    public long GetTimeStamp()
    {
        return CreatedTimestamp;
    }

    public abstract void Process();
}
