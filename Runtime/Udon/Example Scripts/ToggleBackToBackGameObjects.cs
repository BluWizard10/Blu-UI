using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

// Written by BluWizard - https://github.com/BluWizard10

namespace BluWizard.LABS
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    public class ToggleBackToBackGameObjects : UdonSharpBehaviour
    {
        [Header("GameObjects to Enable")]
        [Tooltip("List of GameObjects that should be Enabled when this script runs.")]
        public GameObject[] toEnable;
        
        [Header("GameObjects to Disable")]
        [Tooltip("List of GameObjects that should be Disabled when this script runs.")]
        public GameObject[] toDisable;

        public void _RunEvent() // This is the UdonBehaviour.SendCustomEvent name to use
        {
            foreach (GameObject enable in toEnable)
            {
                enable.SetActive(true);
            }

            foreach (GameObject disable in toDisable)
            {
                disable.SetActive(false);
            }
        }
    }
}