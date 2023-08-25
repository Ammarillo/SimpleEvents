# SimpleEvents
A simple message based eventsystem for unity

## Usage

Just attach the `SimpleEvents.cs` script to a GameObject in your scene. Done!

## Supported Datatypes
The `SimpleEvents.cs` script supports all data types by using a params array of objects. This means you can pass any type of data with an event.

## Examples

### Example 1 - Simple Event
Call Simple Event
```csharp
using UnityEngine;
using SimpleEvents;

public class ExampleScript : MonoBehaviour
{
    void SomeMethod()
    {
        SimpleEvents.Event("sampleName");
    }
}
```

Listening for Simple Events
```csharp
using UnityEngine;
using SimpleEvents;

public class ExampleScript : MonoBehaviour
{
    private void OnEnable()
    {
        SimpleEvents.onEvent += SimpleEventReceived;
    }

    private void OnDisable()
    {
        SimpleEvents.onEvent -= SimpleEventReceived;
    }
  
    void SimpleEventReceived(string eventName, object[] values) 
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
```csharp
using UnityEngine;
using SimpleEvents;

public class ExampleScript : MonoBehaviour
{
  void SomeMethod()
  {
      SimpleEvents.SimpleEvent("sampleName", 123, 12.3f);
  }
}
```

Listening for Simple Events

```csharp
using UnityEngine;
using SimpleEvents;

public class ExampleScript : MonoBehaviour
{
    private void OnEnable()
    {
        SimpleEvents.onEvent += SimpleEventReceived;
    }

    private void OnDisable()
    {
        SimpleEvents.onEvent -= SimpleEventReceived;
    }
  
    void SimpleEventReceived(string eventName, object[] values) 
    {
        if (eventName == "sampleName" && values.Length == 2 && values[0] is int intValue && values[1] is float floatValue)
        {
            //do Something with intValue and floatValue...;
        }
    }
}
```

### troubleshooting
If something does not work, make sure you have added the SimpleEvents script to an active GameObject in your scene.
