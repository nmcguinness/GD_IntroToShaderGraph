using UnityEngine;

namespace GD.Objects
{
    public class PlaceableObject : BaseObject
    {
        [Header("Object Data")]
        [Tooltip("Specify the scriptable object (of type PlaceableObject) which stores the data on this pleaseable object")]
        public PlaceableObjectData PlaceableData;
    }
}