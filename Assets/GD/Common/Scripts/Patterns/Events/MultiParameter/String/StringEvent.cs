using System;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Customer multi-parameter event passing
/// </summary>
/// <see cref="https://www.youtube.com/watch?v=iXNwWpG7EhM"/>
namespace GD.Events
{
    [CreateAssetMenu(fileName = "StringEvent", menuName = "Scriptable Objects/Events/string")]
    public class StringEvent : BaseGameEvent<string>
    {
    }

    [Serializable]
    public class UnityStringEvent : UnityEvent<string>
    {
    }
}