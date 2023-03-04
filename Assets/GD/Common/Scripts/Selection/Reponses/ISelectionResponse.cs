using UnityEngine;

namespace GD.Selection
{
    public interface ISelectionResponse
    {
        void OnSelect(Transform transform, RaycastHit hitInfo);

        void OnDeselect(Transform transform);
    }
}