using System.Collections.Generic;
using UnityEngine;

namespace GD.Events
{
    public abstract class BaseGameEvent<P> : ScriptableObject
    {
        #region Fields

        [SerializeField]
        [Header("Descriptive Information (optional)")]
        [ContextMenuItem("Reset Name", "ResetName")]
        protected string Name;

        protected readonly List<IGameEventListener<P>> listeners = new List<IGameEventListener<P>>();

        #endregion Fields

        [ContextMenu("Raise Event")]
        public virtual void Raise(P parameters)
        {
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised(parameters);
            }
        }

        public void RegisterListener(IGameEventListener<P> listener)
        {
            if (!listeners.Contains(listener))
                listeners.Add(listener);
        }

        public void UnregisterListener(IGameEventListener<P> listener)
        {
            if (listeners.Contains(listener))
                listeners.Remove(listener);
        }
    }
}