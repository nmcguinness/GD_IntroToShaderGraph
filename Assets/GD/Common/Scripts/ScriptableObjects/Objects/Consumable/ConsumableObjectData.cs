using GD.Enums;
using System.Collections.Generic;
using UnityEngine;

namespace GD.Objects
{
    [CreateAssetMenu(fileName = "ConsumableObjectData", menuName = "Scriptable Objects/Game/Objects/Consumable")]
    public class ConsumableObjectData : InteractableObjectData
    {
        [Header("Buff Attributes")]
        [Tooltip("Buffs modify more than one attribute of the entity when consumed (e.g. a potion adds strength and speed")]
        public List<ItemBuff> buffs;
    }

    [System.Serializable]
    public class ItemBuff
    {
        [Tooltip("Specify what attribute of the player does this consumable modify (e.g. strength)")]
        public AttributeType Attribute;

        [Tooltip("Specify the value of the attribute (e.g. 5 stamina points)")]
        public int Value;

        //TODO - lifetime, cooldown period
    }
}