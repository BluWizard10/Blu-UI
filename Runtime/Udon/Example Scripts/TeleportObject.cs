using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

// Written by BluWizard - https://github.com/BluWizard10

namespace BluWizard.LABS
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    public class TeleportObject : UdonSharpBehaviour
    {
        [Tooltip("Which GameObject should be Teleported when this script runs?")]
        public GameObject targetGameObject;

        [Tooltip("Where do you want the Target Game Object teleported to?")]
        public Transform teleportTarget;

        public void _RunEvent() // This is the UdonBehaviour.SendCustomEvent name to use
        {
            targetGameObject.transform.SetPositionAndRotation(teleportTarget.position, teleportTarget.rotation);
        }
    }
}