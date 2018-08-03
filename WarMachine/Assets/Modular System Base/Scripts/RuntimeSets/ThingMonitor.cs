using System;
using UnityEngine;
using UnityEngine.UI;

namespace WARMachine.Sets.Things
{

    public class ThingMonitor : MonoBehaviour
    {
        public ThingRuntimeSet Set;

        public Text Text;

        private int previousCount = -1;

        // Use this for initialization
        private void OnEnable()
        {
            UpdateText();
        }

        // Update is called once per frame
        void Update()
        {
            if (previousCount != Set.items.Count)
            {
                UpdateText();
                previousCount = Set.items.Count;
            }
        }

        private void UpdateText()
        {
            Text.text = "There are " + Set.items.Count + " things in this collection";
        }
    }
}
