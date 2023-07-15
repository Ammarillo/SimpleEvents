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
```
using Aui.SimpleEvents;

public class ExampleScript : MonoBehaviour
{
  SimpleEvents.events.Event("sampleName");
}
```

Listening for Simple Events
```
using Aui.SimpleEvents;

public class ExampleScript : MonoBehaviour
{
  private void OnEnable()
  {
      SimpleEvents.events.onEvent += EventReceived;
  }

  private void OnDisable()
  {
      SimpleEvents.events.onEvent -= EventReceived;
  }
  
  void EventReceived(string eventName) 
  {
    if (eventName == "sampleName")
    {
      //do Something...;
    }
  }
}
```

### Example 2 - Simple event with integer value
Call Simple Event with integer value
```
using Aui.SimpleEvents;

public class ExampleScript : MonoBehaviour
{
  SimpleEvents.events.IntEvent("sampleName", 123);
}
```

Listening for Simple Events

```
using Aui.SimpleEvents;

public class ExampleScript : MonoBehaviour
{
  private void OnEnable()
  {
      SimpleEvents.events.onIntEvent += EventReceived;
  }

  private void OnDisable()
  {
      SimpleEvents.events.onIntEvent -= EventReceived;
  }
  
  void EventReceived(string eventName, int value) 
  {
    if (eventName == "sampleName")
    {
      //do Something...;
    }
  }
}
```
