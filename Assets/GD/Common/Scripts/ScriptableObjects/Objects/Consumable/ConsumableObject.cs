using UnityEngine;

namespace GD.Objects
{
    public class ConsumableObject : BaseObject
    {
        [Header("Object Data")]
        [Tooltip("Specify the scriptable object (of type ConsumableObjectData) which stores the data on this consumable object")]
        public ConsumableObjectData ConsumableData;
    }
}