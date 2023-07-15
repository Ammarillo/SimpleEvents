# SimpleEvents
A simple message based eventsystem for unity

## Usage

Just attach the `SimpleEvents.cs` script on a gameobject in the scene -> Done

## Supported Datatypes
- Int
- Float
- Bool
- String
- Object
- Vector3
- Vector3Int
- Vector2
- Vector2Int
- Quaternion
- Component
- GameObject

## Examples

### Example 1 - Simple Event
Call Simple Event
```cs
using Aui.SimpleEvents;

SimpleEvents.events.Event("sampleName");
```

Listening for Simple Events
```cs
using Aui.SimpleEvents;

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
```cs
using Aui.SimpleEvents;

SimpleEvents.events.IntEvent("sampleName", value);
```

Listening for Simple Events

```cs
using Aui.SimpleEvents;

SimpleEvents.events.onIntEvent += EventReceived;

void EventReceived(string eventName, int value) 
{
  if (eventName == "sampleName")
  {
    do Something...;
  }
}
```
