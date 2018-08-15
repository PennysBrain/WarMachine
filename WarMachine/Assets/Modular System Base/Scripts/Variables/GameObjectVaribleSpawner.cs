using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WARMachine.Variables
{
    public class GameObjectVaribleSpawner : MonoBehaviour
    {
#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public GameObject Prefab;
        public FloatReference FloatReference;
        public bool SpawnAtStart;
        // Use this for initialization
        void Start()
        {
            if (SpawnAtStart)
            {
                Spawn(FloatReference.Value);
            }
        }

        // Update is called once per frame
        public void Spawn(float amount)
        {
            for (float i = amount; i > 0; i--)
            {
                Instantiate(Prefab, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
            }
        }
    }
}