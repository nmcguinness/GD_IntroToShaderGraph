using GD.Events;
using UnityEngine;

namespace GD.ScriptableTypes
{
    /// <summary>
    /// Stores pickup data collected during the game
    /// </summary>
    /// <see cref="GD.Events.PickupData"/>
    [CreateAssetMenu(fileName = "ListPickupDataVariable", menuName = "Scriptable Objects/Collections/List/PickupData")]
    public class ListPickupDataVariable : ListVariable<PickupData>
    {
    }
}