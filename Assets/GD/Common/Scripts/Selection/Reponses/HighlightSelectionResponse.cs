using UnityEngine;

namespace GD.Selection
{
    public class HighlightSelectionResponse : MonoBehaviour, ISelectionResponse
    {
        [SerializeField]
        [Tooltip("Set selected (highlighted) material for game object")]
        private Material selectedMaterial;

        [SerializeField]
        [Tooltip("Set de-selected (un-highlighted) material for game object")]
        private Material deselectedMaterial;

        void ISelectionResponse.OnDeselect(Transform transform)
        {
            var renderer = transform.GetComponent<Renderer>();

            ///<remarks>we can use c# 7.0 syntax</remarks>
            ///<see cref="https://www.thomasclaudiushuber.com/2020/03/12/c-different-ways-to-check-for-null/"/>

            if (renderer != null)
            {
                renderer.material = deselectedMaterial;
            }
        }

        void ISelectionResponse.OnSelect(Transform transform, RaycastHit hitInfo)
        {
            var renderer = transform.GetComponent<Renderer>();
            if (renderer != null)
                renderer.material = selectedMaterial;
        }
    }
}