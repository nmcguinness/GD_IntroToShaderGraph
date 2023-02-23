using UnityEngine;

namespace GD.ScriptableTypes
{
    [CreateAssetMenu(fileName = "BoolVariable", menuName = "Scriptable Objects/Variables/Bool")]
    public class BoolVariable : ScriptableDataType<bool>
    {
        public void Set(bool a)
        {
            Value = a;
        }

        public void Set(BoolVariable a)
        {
            Value = a.Value;
        }

        public bool Equals(bool other)
        {
            return Value == other;
        }

        public bool Equals(BoolVariable other)
        {
            return Value == other.Value;
        }
    }
}