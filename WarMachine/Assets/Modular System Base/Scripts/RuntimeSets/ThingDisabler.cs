using UnityEngine;

namespace WARMachine.Sets.Things
{
    public class ThingDisabler : MonoBehaviour
    {
        public ThingRuntimeSet Set;

        public void DisableAll()
        {
            //Loop Backwards Since The list may change when disabling
            if (Set.items.Count != 0)
            {
                for (int i = Set.items.Count - 1; i >= 0; i--)
                {
                    Set.items[i].gameObject.SetActive(false);
                }
            }
        }

        public void DisableRandom()
        {
            if (Set.items.Count != 0)
            {
                int index = Random.Range(0, Set.items.Count);
                Set.items[index].gameObject.SetActive(false);
            }
        }

    }
}

