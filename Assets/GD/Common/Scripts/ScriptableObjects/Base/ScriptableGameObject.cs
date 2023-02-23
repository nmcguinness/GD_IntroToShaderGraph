using UnityEngine;

namespace GD.ScriptableTypes
{
    public class ScriptableGameObject : ScriptableObject
    {
        [Header("Description & Type")]
        [ContextMenuItem("Reset Name", "ResetName")]
        public string Name;

        [ContextMenuItem("Reset Description", "ResetDescription")]
        public string Description;

        public void ResetName()
        {
            Name = "";
        }

        public void ResetDescription()
        {
            Description = "";
        }
    }
}