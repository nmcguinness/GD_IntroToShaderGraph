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

        public void OnSelect(Transform selection)
        {
            var renderer = selection.GetComponent<Renderer>();
            if (renderer != null)
                renderer.material = selectedMaterial;
        }

        public void OnDeselect(Transform selection)
        {
            var renderer = selection.GetComponent<Renderer>();

            ///<remarks>we can use c# 7.0 syntax</remarks>
            ///<see cref="https://www.thomasclaudiushuber.com/2020/03/12/c-different-ways-to-check-for-null/"/>
            
            if (renderer != null)
            {
                renderer.material = deselectedMaterial;
            }
        }
    }
}
