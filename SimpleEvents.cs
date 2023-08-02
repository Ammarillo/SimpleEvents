using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleEvents
{
    /// <summary>
    /// Make sure to attach this script on GameObject in your active scene.
    /// </summary>
    public class SimpleEvents : MonoBehaviour
    {
        /// <summary>
        /// Use this to call an receive events.
        /// </summary>
        public static SimpleEvents events;

        private void Awake()
        {
            events = this;
        }

        #region Event
        /// <summary>
        /// Receives all normale events.
        /// <code>
        /// SimpleEvents.events.onEvent += EventReceived;
        /// 
        /// void EventReceived(string eventName) 
        /// {
        ///     if (eventName == "sampleName")
        ///     {
        ///         do Something...;
        ///     }
        /// }
        /// </code>
        /// </summary>
        public event Action<string> onEvent;

        /// <summary>
        /// Sends an simple event to all subscribers.
        /// <code>
        /// SimpleEvents.events.Event("sampleName");
        /// </code>
        /// </summary>
        public void Event(string eventName)
        {
            if (onEvent != null)
            {
                onEvent(eventName);
            }
        }

        #endregion

        #region ComponentEvent
        /// <summary>
        /// Receives all Component events.
        /// <code>
        /// SimpleEvents.events.onComponentEvent += EventReceived;
        /// 
        /// void EventReceived(string eventName) 
        /// {
        ///     if (eventName == "sampleName")
        ///     {
        ///         do Something...;
        ///     }
        /// }
        /// </code>
        /// </summary>
        public event Action<string, Component> onComponentEvent;

        /// <summary>
        /// Sends an componen event to all subscribers.
        /// <code>
        /// SimpleEvents.events.Event("sampleName", Component component);
        /// </code>
        /// </summary>
        public void ComponentEvent(string eventName, Component component)
        {
            if (onComponentEvent != null)
            {
                onComponentEvent(eventName, component);
            }
        }
        #endregion

        #region GameObjectEvent
        /// <summary>
        /// Receives all GameObject events.
        /// <code>
        /// SimpleEvents.events.onGameObjectEvent += EventReceived;
        /// 
        /// void EventReceived(string eventName, GameObject obj) 
        /// {
        ///     if (eventName == "sampleName")
        ///     {
        ///         do Something...;
        ///     }
        /// }
        /// </code>
        /// </summary>
        public event Action<string, GameObject> onGameObjectEvent;

        /// <summary>
        /// Sends an GameObject event to all subscribers.
        /// <code>
        /// SimpleEvents.events.GameObjectEvent("sampleName", GameObject obj);
        /// </code>
        /// </summary>
        public void GameObjectEvent(string eventName, GameObject obj)
        {
            if (onGameObjectEvent != null)
            {
                onGameObjectEvent(eventName, obj);
            }
        }
        #endregion

        #region IntEvent
        /// <summary>
        /// Receives all Integer events.
        /// <code>
        /// SimpleEvents.events.onIntEvent += EventReceived;
        /// 
        /// void EventReceived(string eventName, int value) 
        /// {
        ///     if (eventName == "sampleName")
        ///     {
        ///         do Something...;
        ///     }
        /// }
        /// </code>
        /// </summary>
        public event Action<string, int> onIntEvent;

        /// <summary>
        /// Sends an Integer event to all subscribers.
        /// <code>
        /// SimpleEvents.events.IntEvent("sampleName", int value);
        /// </code>
        /// </summary>
        public void IntEvent(string eventName, int value)
        {
            if (onIntEvent != null)
            {
                onIntEvent(eventName, value);
            }
        }
        #endregion

        #region FloatEvent
        /// <summary>
        /// Receives all Float events.
        /// <code>
        /// SimpleEvents.events.onFloatEvent += EventReceived;
        /// 
        /// void EventReceived(string eventName, float value) 
        /// {
        ///     if (eventName == "sampleName")
        ///     {
        ///         do Something...;
        ///     }
        /// }
        /// </code>
        /// </summary>
        public event Action<string, float> onFloatEvent;

        /// <summary>
        /// Sends an Float event to all subscribers.
        /// <code>
        /// SimpleEvents.events.IntEvent("sampleName", float value);
        /// </code>
        /// </summary>
        public void FloatEvent(string eventName, float value)
        {
            if (onFloatEvent != null)
            {
                onFloatEvent(eventName, value);
            }
        }
        #endregion

        #region StringEvent
        /// <summary>
        /// Receives all String events.
        /// <code>
        /// SimpleEvents.events.onStringEvent += EventReceived;
        /// 
        /// void EventReceived(string eventName, string value) 
        /// {
        ///     if (eventName == "sampleName")
        ///     {
        ///         do Something...;
        ///     }
        /// }
        /// </code>
        /// </summary>
        public event Action<string, string> onStringEvent;

        /// <summary>
        /// Sends an String event to all subscribers.
        /// <code>
        /// SimpleEvents.events.StringEvent("sampleName", string value);
        /// </code>
        /// </summary>
        public void StringEvent(string eventName, string value)
        {
            if (onStringEvent != null)
            {
                onStringEvent(eventName, value);
            }
        }
        #endregion

        #region BoolEvent
        /// <summary>
        /// Receives all Boolean events.
        /// <code>
        /// SimpleEvents.events.onBoolEvent += EventReceived;
        /// 
        /// void EventReceived(string eventName, bool value) 
        /// {
        ///     if (eventName == "sampleName")
        ///     {
        ///         do Something...;
        ///     }
        /// }
        /// </code>
        /// </summary>
        public event Action<string, bool> onBoolEvent;

        /// <summary>
        /// Sends an Boolean event to all subscribers.
        /// <code>
        /// SimpleEvents.events.BoolEvent("sampleName", bool value);
        /// </code>
        /// </summary>
        public void BoolEvent(string eventName, bool value)
        {
            if (onBoolEvent != null)
            {
                onBoolEvent(eventName, value);
            }
        }
        #endregion

        #region ObjectEvent
        /// <summary>
        /// Receives all System Object events.
        /// <code>
        /// SimpleEvents.events.onObjectEvent += EventReceived;
        /// 
        /// void EventReceived(string eventName, System.Object value) 
        /// {
        ///     if (eventName == "sampleName")
        ///     {
        ///         do Something...;
        ///     }
        /// }
        /// </code>
        /// </summary>
        public event Action<string, System.Object> onObjectEvent;

        /// <summary>
        /// Sends an System Object event to all subscribers.
        /// <code>
        /// SimpleEvents.events.ObjectEvent("sampleName", System.Object value);
        /// </code>
        /// </summary>
        public void ObjectEvent(string eventName, System.Object obj)
        {
            if (onObjectEvent != null)
            {
                onObjectEvent(eventName, obj);
            }
        }
        #endregion

        #region UnityObjectEvent
        /// <summary>
        /// Receives all Unity Object events.
        /// <code>
        /// SimpleEvents.events.onUnityObjectEvent += EventReceived;
        /// 
        /// void EventReceived(string eventName, UnityEngine.Object value) 
        /// {
        ///     if (eventName == "sampleName")
        ///     {
        ///         do Something...;
        ///     }
        /// }
        /// </code>
        /// </summary>
        public event Action<string, UnityEngine.Object> onUnityObjectEvent;

        /// <summary>
        /// Sends an Unity Object event to all subscribers.
        /// <code>
        /// SimpleEvents.events.UnityObjectEvent("sampleName", UnityEngine.Object value);
        /// </code>
        /// </summary>
        public void UnityObjectEvent(string eventName, UnityEngine.Object obj)
        {
            if (onUnityObjectEvent != null)
            {
                onUnityObjectEvent(eventName, obj);
            }
        }
        #endregion

        #region Vector3Event
        /// <summary>
        /// Receives all Vector3 events.
        /// <code>
        /// SimpleEvents.events.onVector3Event += EventReceived;
        /// 
        /// void EventReceived(string eventName, Vector3 vector) 
        /// {
        ///     if (eventName == "sampleName")
        ///     {
        ///         do Something...;
        ///     }
        /// }
        /// </code>
        /// </summary>
        public event Action<string, Vector3> onVector3Event;

        /// <summary>
        /// Sends an Vector3 event to all subscribers.
        /// <code>
        /// SimpleEvents.events.UnityObjectEvent("sampleName", Vector3 vector);
        /// </code>
        /// </summary>
        public void Vector3Event(string eventName, Vector3 vector)
        {
            if (onVector3Event != null)
            {
                onVector3Event(eventName, vector);
            }
        }
        #endregion

        #region Vector3IntEvent
        /// <summary>
        /// Receives all Vector3Int events.
        /// <code>
        /// SimpleEvents.events.onVector3IntEvent += EventReceived;
        /// 
        /// void EventReceived(string eventName, Vector3Int vector) 
        /// {
        ///     if (eventName == "sampleName")
        ///     {
        ///         do Something...;
        ///     }
        /// }
        /// </code>
        /// </summary>
        public event Action<string, Vector3Int> onVector3IntEvent;

        /// <summary>
        /// Sends an Vector3Int event to all subscribers.
        /// <code>
        /// SimpleEvents.events.UnityObjectEvent("sampleName", Vector3Int vector);
        /// </code>
        /// </summary>
        public void Vector3IntEvent(string eventName, Vector3Int vector)
        {
            if (onVector3IntEvent != null)
            {
                onVector3IntEvent(eventName, vector);
            }
        }
        #endregion

        #region Vector2Event
        /// <summary>
        /// Receives all Vector2 events.
        /// <code>
        /// SimpleEvents.events.onVector2Event += EventReceived;
        /// 
        /// void EventReceived(string eventName, Vector2 vector) 
        /// {
        ///     if (eventName == "sampleName")
        ///     {
        ///         do Something...;
        ///     }
        /// }
        /// </code>
        /// </summary>
        public event Action<string, Vector2> onVector2Event;

        /// <summary>
        /// Sends an Vector2 event to all subscribers.
        /// <code>
        /// SimpleEvents.events.UnityObjectEvent("sampleName", Vector2 vector);
        /// </code>
        /// </summary>
        public void Vector2Event(string eventName, Vector2 vector)
        {
            if (onVector2Event != null)
            {
                onVector2Event(eventName, vector);
            }
        }
        #endregion

        #region Vector2IntEvent
        /// <summary>
        /// Receives all Vector2Int events.
        /// <code>
        /// SimpleEvents.events.onVector2IntEvent += EventReceived;
        /// 
        /// void EventReceived(string eventName, Vector2Int vector) 
        /// {
        ///     if (eventName == "sampleName")
        ///     {
        ///         do Something...;
        ///     }
        /// }
        /// </code>
        /// </summary>
        public event Action<string, Vector2Int> onVector2IntEvent;

        /// <summary>
        /// Sends an Vector2Int event to all subscribers.
        /// <code>
        /// SimpleEvents.events.UnityObjectEvent("sampleName", Vector2Int vector);
        /// </code>
        /// </summary>
        public void Vector2IntEvent(string eventName, Vector2Int vector)
        {
            if (onVector2IntEvent != null)
            {
                onVector2IntEvent(eventName, vector);
            }
        }
        #endregion

        #region QuaternionEvent
        /// <summary>
        /// Receives all Quaternion events.
        /// <code>
        /// SimpleEvents.events.onQuaternion += EventReceived;
        /// 
        /// void EventReceived(string eventName, Quaternion quaternion) 
        /// {
        ///     if (eventName == "sampleName")
        ///     {
        ///         do Something...;
        ///     }
        /// }
        /// </code>
        /// </summary>
        public event Action<string, Quaternion> onQuaternionEvent;

        /// <summary>
        /// Sends an Quaternion event to all subscribers.
        /// <code>
        /// SimpleEvents.events.UnityObjectEvent("sampleName", Quaternion quaternion);
        /// </code>
        /// </summary>
        public void QuaternionEvent(string eventName, Quaternion vector)
        {
            if (onQuaternionEvent != null)
            {
                onQuaternionEvent(eventName, vector);
            }
        }
        #endregion
    }
}

