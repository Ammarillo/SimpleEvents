# SimpleEvents
A simple message based eventsystem for unity

## Usage

Just attach the `SimpleEvents.cs` script on a gameobject in the scene -> Done

## Example

Call Event
```
SimpleEvents.events.Event("sampleName");
```

Listening for Events

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
