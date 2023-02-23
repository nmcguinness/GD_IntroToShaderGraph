using UnityEngine;

namespace GD.Selection
{
    public class RayCastSelector : MonoBehaviour, ISelector
    {
        [SerializeField]
        private string selectableTag = "Selectable";

        [SerializeField]
        private LayerMask layerMask;

        [SerializeField]
        [Range(0, 1000)]
        private float maxDistance = 100;

        private Transform selection;
        private RaycastHit hitInfo;

        public Transform GetSelection()
        {
            return selection;
        }

        public RaycastHit GetHitInfo()
        {
            return hitInfo;
        }

        public void Check(Ray ray)
        {
            selection = null;
            if (Physics.Raycast(ray, out hitInfo, maxDistance, layerMask.value))
            {
                var currentSelection = hitInfo.transform;
                if (currentSelection.CompareTag(selectableTag))
                    selection = currentSelection;
            }
        }
    }
}