using UnityEngine;

/// <summary>
/// Contains a set of ScriptableObject(SO) data types (float, int, bool) and reference types that can switch between a local variable (e.g float) or reference to a shared variable (e.g. FloatVariable)
/// </summary>
namespace GD.ScriptableTypes
{
    #region Generic Type

    [System.Serializable]
    public abstract class ScriptableDataType<T> : ScriptableGameObject
    {
        [Header("Value")]
        [ContextMenuItem("Reset Value", "ResetValue")]
        public T Value;

        public virtual void ResetValue()
        {
            Value = default(T);
        }
    }

    #endregion Generic Type

    #region Reference Types

    //Generic type to replace BoolReference, IntReference etc

    [System.Serializable]
    public class BaseReference<T>
    {
        public bool UseConstant = true;
        public T ConstantValue;
    }

    [System.Serializable]
    public class BoolReference : BaseReference<bool>
    {
        public BoolVariable Variable;
        public bool Value => UseConstant ? ConstantValue : Variable.Value;
    }

    [System.Serializable]
    public class IntReference : BaseReference<int>
    {
        public IntVariable Variable;
        public int Value => UseConstant ? ConstantValue : Variable.Value;
    }

    [System.Serializable]
    public class FloatReference : BaseReference<float>
    {
        public FloatVariable Variable;
        public float Value => UseConstant ? ConstantValue : Variable.Value;
    }

    [System.Serializable]
    public class StringReference : BaseReference<string>
    {
        public StringVariable Variable;
        public string Value => UseConstant ? ConstantValue : Variable.Value;
    }

    [System.Serializable]
    public class Vector3Reference : BaseReference<Vector3>
    {
        public Vector3Variable Variable;
        public Vector3 Value => UseConstant ? ConstantValue : Variable.Value;
    }

    #endregion Reference Types
}