using UnityEngine;

namespace GD.ScriptableTypes
{
    /// <summary>
    /// Stores string variables e.g. Waypoint descriptions in the game
    /// </summary>
    [CreateAssetMenu(fileName = "ListStringVariable", menuName = "Scriptable Objects/Collections/List/String")]
    public class ListStringVariable : ListVariable<string>
    {
    }
}