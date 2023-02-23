namespace GD.ScriptableTypes
{
    /// <summary>
    /// Base class for IntVariable, FloatVariable and any other numeric variable (e.g. Double) added in time
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class NumberVariable<T> : ScriptableDataType<T>
    {
    }
}