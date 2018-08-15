using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace WARMachine.Variables
{
    public class FloatToText : MonoBehaviour
    {
        public Text Text;

        public FloatVariable Variable;

        public bool DebugMode;

        public bool AlwaysUpdate;
        

        private void OnEnable()
        {
            if(!DebugMode)
                Text.text = Variable.Value.ToString();
            else
                Text.text = Variable.name + " : "+ Variable.Value.ToString();

        }

        private void Update()
        {
            if (AlwaysUpdate)
            {
                if (!DebugMode)
                    Text.text = Variable.Value.ToString();
                else
                    Text.text = Variable.name + " : " + Variable.Value.ToString();

            }
        }
    }
}
