using UnityEngine;

namespace GD.Objects
{
    [CreateAssetMenu(fileName = "InteractableObjectData", menuName = "Scriptable Objects/Game/Objects/Interactable")]
    public class InteractableObjectData : BaseObjectData
    {
        [Header("UI Icon")]
        [Tooltip("Icon used by onscreen UI and any notification panel popups")]
        public Sprite icon;

        [Header("Audio")]
        [Tooltip("Audio clipped played when interactable is picked up")]
        public AudioClip PickupClip;

        [Tooltip("Audio clipped played when interactable is used")]
        public AudioClip UseClip;

        [Tooltip("Audio clipped played when interactable is dropped")]
        public AudioClip DropClip;

        [Header("Life & Respawn")]
        [Tooltip("Amount of time before a visible unused item is removed (-1 = no removal)")]
        public float LivesForMs;

        [Tooltip("Amount of time until respawn following consumption (-1 = respawn never, 0 = respawn immediate)")]
        public float RespawnEveryMs;
    }
}