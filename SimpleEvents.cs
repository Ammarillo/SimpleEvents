using System;
using UnityEngine;

namespace SimpleEvents
{
    public class SimpleEvents : MonoBehaviour
    {
        /// <summary>
        /// Singleton instance of SimpleEvents.
        /// </summary>
        private static SimpleEvents instance;

        /// <summary>
        /// Receives all SimpleEvents.
        /// </summary>
        private event Action<string, object[]> onSimpleEvent;

        /// <summary>
        /// Receives all SimpleEvents.
        /// </summary>
        public static event Action<string, object[]> onEvent;

        private void Awake()
        {
            // Ensure there is only one instance of SimpleEvents.
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        /// <summary>
        /// Sends a SimpleEvent to all subscribers with any number of data.
        /// </summary>
        private void SimpleEvent(string eventName, params object[] data)
        {
            onSimpleEvent?.Invoke(eventName, data);
        }

        /// <summary>
        /// Adds a delegate to the event.
        /// </summary>
        public static void AddOnSimpleEvent(Action<string, object[]> action)
        {
            instance.onSimpleEvent += action;
        }

        /// <summary>
        /// Removes a delegate from the event.
        /// </summary>
        public static void RemoveOnSimpleEvent(Action<string, object[]> action)
        {
            instance.onSimpleEvent -= action;
        }

        /// <summary>
        /// Sends a SimpleEvent to all subscribers with any number of data.
        /// </summary>
        public static void Event(string eventName, params object[] data)
        {
            // First, trigger instance event
            instance.SimpleEvent(eventName, data);

            // Then, trigger static event
            onEvent?.Invoke(eventName, data);
        }
    }
}

