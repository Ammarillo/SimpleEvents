using System;
using UnityEngine;

namespace SimpleEvents
{
    /// <summary>
    /// Use this to call an receive events.
    /// </summary>
    public static SimpleEvents events;

    private void Awake()
    {
        events = this;
    }

    #region SimpleEvent
    /// <summary>
    /// Receives all SimpleEvents.
    /// <code>
    /// SimpleEvents.events.onSimpleEvent += EventReceived;
    /// 
    /// void EventReceived(string eventName, params object[] values) 
    /// {
    ///     if (eventName == "sampleName")
    ///     {
    ///         do Something...;
    ///     }
    /// }
    /// </code>
    /// </summary>
    public event Action<string, object[]> onSimpleEvent;

    /// <summary>
    /// Sends a SimpleEvent to all subscribers with any number of values.
    /// <code>
    /// SimpleEvents.events.SimpleEvent("sampleName", value1, value2, ..., valueN);
    /// </code>
    /// </summary>
    public void SimpleEvent(string eventName, params object[] values)
    {
        if (onSimpleEvent != null)
        {
            onSimpleEvent(eventName, values);
        }
    }
    #endregion
}

