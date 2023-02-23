using UnityEngine;

namespace GD.Selection
{
    public interface ISelectionResponse
    {
        void OnSelect(Transform transform);
        void OnDeselect(Transform transform);
    }
}
