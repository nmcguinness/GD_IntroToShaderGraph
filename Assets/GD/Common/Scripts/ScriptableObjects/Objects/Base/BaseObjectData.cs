using GD.Enums;
using GD.ScriptableTypes;
using UnityEngine;

namespace GD.Objects
{
    /// <see cref="https://www.youtube.com/watch?v=PVOVIxNxxeQ"/>
    public abstract class BaseObjectData : ScriptableGameObject
    {
        [Tooltip("Specify the type of this object (e.g. equipment, food, weapon)")]
        public ItemType Type;
    }
}