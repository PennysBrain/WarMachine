using UnityEngine;
using UnityEngine.Events;


namespace WARMachine.Events
{
    public class GameEventListener : MonoBehaviour
    {
        [Tooltip("Event To Register With")]
        public GameEvent Event;

        [Tooltip("Response to invoke when Event is raised")]
        public UnityEvent Response;

        private void OnEnable()
        {
            if (Event)
                Event.RegisterListener(this);
            else
                Debug.Log(this.gameObject.name + " has Listener But no Event");
        }


        public void OnDisable()
        {
            if(Event != null)
                Event.UnregisterListener(this);
        }

        public void OnEventRaised()
        {
            Response.Invoke();
        }
    }
}
