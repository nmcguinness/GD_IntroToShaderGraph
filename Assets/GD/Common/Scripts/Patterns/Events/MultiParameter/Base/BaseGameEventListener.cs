using UnityEngine;
using UnityEngine.Events;

namespace GD.Events
{
    public class BaseGameEventListener<P, E, R> : MonoBehaviour,
        IGameEventListener<P> where E : BaseGameEvent<P> where R : UnityEvent<P>
    {
        [SerializeField]
        private E gameEvent;

        [SerializeField]
        private R response;

        protected E GameEvent { get => gameEvent; set => gameEvent = value; }
        protected R Response { get => response; set => response = value; }

        private void OnEnable()
        {
            GameEvent?.RegisterListener(this);
        }

        private void OnDisable()
        {
            GameEvent?.UnregisterListener(this);
        }

        public virtual void OnEventRaised(P parameters)
        {
            Response?.Invoke(parameters);
        }
    }
}