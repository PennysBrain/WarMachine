using WARMachine.Variables;
using UnityEngine;

namespace WARMachine.Events
{
    public class EventTimer : MonoBehaviour
    {
#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif

        [Tooltip("Event To Raise")]
        public GameEvent Event;

        public bool ActiveatStart;
        public FloatReference ResetTimer;
        public float currentTime;
        // Use this for initialization
        void Start()
        {
            if (ActiveatStart)
            {
                ActivateEvent();
            }
        }

        void Update()
        {
            currentTime -= Time.deltaTime;
            if (currentTime < 0)
            {
                ActivateEvent();
                Debug.Log("THIS HAPPPENS");
                currentTime = ResetTimer;
            }
        }

        void ActivateEvent()
        {
            Event.Raise();
        }
    }
}
