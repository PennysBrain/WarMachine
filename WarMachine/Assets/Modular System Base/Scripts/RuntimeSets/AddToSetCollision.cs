using System.Collections;
using WARMachine.Sets.Things;
using UnityEngine;

public class AddToSetCollision : MonoBehaviour
{
    public ThingRuntimeSet Set;

    public void Start()
    {
        Set.items.Clear();//Cheap hack to get rid of that pesky 1 that adds up        
    }

    public void OnTriggerEnter(Collider other)
    {
        Thing thing = other.gameObject.GetComponent<Thing>();
        if (thing != null)
        {
            Debug.Log(other.gameObject.name + " This was added to  " + this.gameObject.name.ToString());
            Set.Add(thing);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        Thing thing = other.gameObject.GetComponent<Thing>();
        if (thing != null)
        {
            Debug.Log(other.gameObject.name + " This was Removed from  " + this.gameObject.name.ToString());
            Set.Remove(thing);
        }
    }

}
