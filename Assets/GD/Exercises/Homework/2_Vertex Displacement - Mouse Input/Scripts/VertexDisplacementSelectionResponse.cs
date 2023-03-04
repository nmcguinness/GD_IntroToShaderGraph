using UnityEngine;

namespace GD.Selection
{
    public class VertexDisplacementSelectionResponse : MonoBehaviour, ISelectionResponse
    {
        [SerializeField]
        private Material material;

        private int distortionCentreID;
        private int displaceVerticesID;

        // Start is called before the first frame update
        private void Start()
        {
            distortionCentreID = Shader.PropertyToID("_Distortion_Centre");
            //      displaceVerticesID = Shader.PropertyToID("_Displace_Vertices");
        }

        void ISelectionResponse.OnSelect(Transform transform, RaycastHit hitInfo)
        {
            if (material == null)
                return;

            //       material.SetInteger(displaceVerticesID, 1);
            material.SetVector(distortionCentreID, transform.InverseTransformPoint(hitInfo.point));
        }

        void ISelectionResponse.OnDeselect(Transform transform)
        {
            if (material == null)
                return;

            //     material.SetInteger(displaceVerticesID, 0);
        }
    }
}