using UnityEngine;

namespace GD.Objects
{
    public class InteractableObject : BaseObject
    {
        [Header("Object Data")]
        [Tooltip("Specify the scriptable object (of type InteractableObjectData) which stores the data on this interactable object")]
        public InteractableObjectData InteractableData;
    }
}