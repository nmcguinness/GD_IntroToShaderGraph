using UnityEngine;

namespace GD.ScriptableTypes
{
    [CreateAssetMenu(fileName = "StringVariable", menuName = "Scriptable Objects/Variables/String")]
    public class StringVariable : ScriptableDataType<string>
    {
        public void Set(string a)
        {
            Value = a;
        }

        public void Set(StringVariable a)
        {
            Value = a.Value;
        }

        public bool IsNullOrEmpty()
        {
            return string.IsNullOrEmpty(Value);
        }

        public void Clear()
        {
            Value = string.Empty;
        }

        public bool Equals(string other)
        {
            return Value.Equals(other);
        }

        public bool Equals(StringVariable other)
        {
            return Value.Equals(other.Value);
        }
    }
}