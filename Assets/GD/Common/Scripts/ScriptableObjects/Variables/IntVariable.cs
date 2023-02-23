using UnityEngine;

namespace GD.ScriptableTypes
{
    [CreateAssetMenu(fileName = "IntVariable", menuName = "Scriptable Objects/Variables/Int")]
    public class IntVariable : NumberVariable<int>
    {
        public void Add(int a)
        {
            Value += a;
        }

        public void Add(IntVariable a)
        {
            Value += a.Value;
        }

        public void Set(int a)
        {
            Value = a;
        }

        public void Set(IntVariable a)
        {
            Value = a.Value;
        }

        public bool Equals(int other)
        {
            return Value == other;
        }

        public bool Equals(IntVariable other)
        {
            return Value == other.Value;
        }
    }
}