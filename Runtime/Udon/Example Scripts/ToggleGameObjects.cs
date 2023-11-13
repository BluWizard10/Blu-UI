using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UdonSharp;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor;
using UnityEditor.UIElements;
using VRC.SDKBase;
using VRC.Udon;

// Written by BluWizard - https://github.com/BluWizard10

namespace BluWizard.LABS
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    public class ToggleGameObjects : UdonSharpBehaviour
    {
        [Tooltip("What GameObjects should be Toggled when this script runs?")]
        public GameObject[] targetObjects; // Show GameObject Targets as a List

        public void _RunEvent() // This is the UdonBehaviour.SendCustomEvent name to use
        {
            foreach (GameObject targetObject in targetObjects)
            {
                targetObject.SetActive(!targetObject.activeSelf);
            }
        }
    }
}