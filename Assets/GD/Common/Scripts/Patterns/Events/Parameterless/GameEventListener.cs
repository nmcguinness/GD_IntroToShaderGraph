using UnityEngine;
using UnityEngine.Events;

namespace GD.Events
{
    public class GameEventListener : MonoBehaviour
    {
        [SerializeField]
        private string description;

        [SerializeField]
        [Tooltip("Specify the game event (scriptable object) which will raise the event")]
        private GameEvent Event;

        [SerializeField]
        private UnityEvent Response;

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public virtual void OnEventRaised()
        {
            Response?.Invoke();
        }
    }
}