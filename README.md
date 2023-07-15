# SimpleEvents
A simple message based eventsystem for unity

## Usage

Just attach the `SimpleEvents.cs` script on a gameobject in the scene -> Done

## Examples

### Example 1 - Simple Event
Call Simple Event
```
SimpleEvents.events.Event("sampleName");
```

Listening for Simple Events

```
SimpleEvents.events.onEvent += EventReceived;

void EventReceived(string eventName) 
{
  if (eventName == "sampleName")
  {
    do Something...;
  }
}
```

### Example 2 - Simple event with integer value
Call Simple Event with integer value
```
SimpleEvents.events.IntEvent("sampleName", value);
```

Listening for Simple Events

```
SimpleEvents.events.onIntEvent += EventReceived;

void EventReceived(string eventName, int value) 
{
  if (eventName == "sampleName")
  {
    do Something...;
  }
}
```
