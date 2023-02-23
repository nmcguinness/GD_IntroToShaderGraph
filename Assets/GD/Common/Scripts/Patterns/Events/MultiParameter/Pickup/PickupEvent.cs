using System;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Customer multi-parameter event passing
/// </summary>
/// <see cref="https://www.youtube.com/watch?v=iXNwWpG7EhM"/>
namespace GD.Events
{
    [Serializable]
    public enum PickupType : sbyte
    {
        Health, Ammo, Mana
    }

    [Serializable]
    public struct PickupData
    {
        public int value;
        public PickupType type;
        public GameObject pickup;

        public override string ToString()
        {
            return $"{type}, {value}";
        }
    }

    [CreateAssetMenu(fileName = "PickupEvent", menuName = "Scriptable Objects/Events/Pickup")]
    public class PickupEvent : BaseGameEvent<PickupData>
    {
        //public override void Raise(PickupData parameters)
        //{
        //    base.Raise(parameters);
        //}
    }

    [Serializable]
    public class UnityPickupEvent : UnityEvent<PickupData>
    {
    }
}