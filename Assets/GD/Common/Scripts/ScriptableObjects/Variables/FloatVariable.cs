using UnityEngine;

namespace GD.ScriptableTypes
{
    [CreateAssetMenu(fileName = "FloatVariable", menuName = "Scriptable Objects/Variables/Float")]
    public class FloatVariable : NumberVariable<float>
    {
        public void Add(float a)
        {
            Value += a;
        }

        public void Add(FloatVariable a)
        {
            Value += a.Value;
        }

        public void Set(float a)
        {
            Value = a;
        }

        public void Set(FloatVariable a)
        {
            Value = a.Value;
        }

        /// <summary>
        /// Compare within Epsilon
        /// /// </summary>
        /// <see cref="https://docs.unity3d.com/ScriptReference/Mathf.Approximately.html"/>
        public bool Equals(float other)
        {
            return Mathf.Approximately(Value, other);
        }

        /// <summary>
        /// Compare within Epsilon
        /// /// </summary>
        /// <see cref="https://docs.unity3d.com/ScriptReference/Mathf.Approximately.html"/>
        public bool Equals(FloatVariable other)
        {
            return Mathf.Approximately(Value, other.Value);
        }
    }
}