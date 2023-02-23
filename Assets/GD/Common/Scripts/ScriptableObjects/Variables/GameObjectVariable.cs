using UnityEngine;

namespace GD.ScriptableTypes
{
    [CreateAssetMenu(fileName = "GameObjectVariable", menuName = "Scriptable Objects/Variables/Game Object")]
    public class GameObjectVariable : ScriptableDataType<GameObject>
    {
    }
}