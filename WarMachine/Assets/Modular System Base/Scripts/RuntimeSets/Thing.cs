using UnityEngine;

namespace WARMachine.Sets.Things
{
    //Adds it and Removes it to Collection 
    //Auto when attach to GameObject
    public class Thing : MonoBehaviour
    {
        public ThingRuntimeSet RuntimeSet;

        private void OnEnable()
        {
            RuntimeSet.Add(this);
        }

        private void OnDisable()
        {
            RuntimeSet.Remove(this);
        }

    }
}
